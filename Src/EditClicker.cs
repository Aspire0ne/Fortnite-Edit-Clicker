using FortniteAutoclicker.Src;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace FortniteAutoclicker
{
    class EditClicker
    {
        readonly MicroStopwatch MicroStopwatch = new MicroStopwatch();
        readonly Stopwatch RegularStopwatch = new Stopwatch();

        enum ClickType { Left, Right }

        public enum PowerMode { Normal, High, Ultra }

        PowerMode _mode;
        Action<uint> SleepMethod;

        public PowerMode Mode
        {
            get => _mode;
            set
            {
                PowerMode previousMode = _mode;

                SleepMethod = (_mode = value) switch
                {
                    PowerMode.Normal => NormalModeSleep,
                    PowerMode.High => HighModeSleep,
                    PowerMode.Ultra => UltraModeSleep,
                    _ => throw new NotImplementedException($"Power mode {value} was not handled.")
                };

                if (value == PowerMode.Ultra)
                {
                    ChangeActionDelay((ushort)ActionDelay);
                    ChangeLoopDelay((ushort)LoopDelay);
                }
                else if (previousMode == PowerMode.Ultra)
                {
                    ChangeActionDelay((ushort)(ActionDelay / 1000));
                    ChangeLoopDelay((ushort)(LoopDelay / 1000));
                }
            }
        }

        public const byte MinimalDelayBetweenActions = 0;
        public const byte MinimalDelayBetweenLoops = 0;
        const byte TimerResolution = 1;
        static readonly VirtualKeyCode EditKey = VirtualKeyCode.VK_G;
        readonly InputSimulator InputSim = new InputSimulator();
        public bool Running { get; private set; }
        uint ActionDelay;
        uint LoopDelay;

        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)] public static extern uint TimeBeginPeriod(uint uMilliseconds);

        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", SetLastError = true)] public static extern uint TimeEndPeriod(uint uMilliseconds);

        public EditClicker(ushort actionDelay, ushort loopDelay, PowerMode mode = PowerMode.Normal)
        {
            ActionDelay = actionDelay;
            LoopDelay = loopDelay;
            Mode = mode;
        }

        public void Toggle()
        {
            if (Running)
            {
                Running = false;
                TimeEndPeriod(TimerResolution);
            }
            else
            {
                Running = true;
                TimeBeginPeriod(TimerResolution);
                StartEditing();
            }
        }

        void StartEditing()
        {
            while (Running)
            {
                ClickInEditMode(ClickType.Left);
                SleepMethod.Invoke(LoopDelay);
            }

            ClickInEditMode(ClickType.Right);
            InputSim.Mouse.LeftButtonUp();

            if (MicroStopwatch.IsRunning)
                MicroStopwatch.Stop();
            if (RegularStopwatch.IsRunning)
                RegularStopwatch.Stop();
        }

        void ClickInEditMode(ClickType click)
        {
            PressEditKey();
            SleepMethod.Invoke(ActionDelay);

            if (click == ClickType.Left)
                InputSim.Mouse.LeftButtonDown();
            else
                InputSim.Mouse.RightButtonClick();

            SleepMethod.Invoke(ActionDelay);
            PressEditKey();
        }

        void PressEditKey() => InputSim.Keyboard.KeyPress(EditKey);

        void NormalModeSleep(uint intervalMillis) => Thread.Sleep((int)intervalMillis - 1);

        void HighModeSleep(uint intervalMillis)
        {
            RegularStopwatch.Restart();
            while (RegularStopwatch.Elapsed.Milliseconds < intervalMillis) { }
        }

        void UltraModeSleep(uint intervalMicros)
        {
            MicroStopwatch.Restart();
            while (MicroStopwatch.ElapsedMicroseconds < intervalMicros) { }
        }

        // Must use method instead of property, because in other parts of the code a delegate is needed to be passed
        public void ChangeActionDelay(ushort actionDelay) => ActionDelay = (uint)(actionDelay * (_mode == PowerMode.Ultra ? 1000 : 1));

        public void ChangeLoopDelay(ushort loopDelay) => LoopDelay = (uint)(loopDelay * (_mode == PowerMode.Ultra ? 1000 : 1));
    }
}
