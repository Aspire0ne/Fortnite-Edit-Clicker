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
        public enum PowerMode { Balanced, High, Ultra }
        PowerMode _mode;
        Action<ushort> SleepMethod;
        public PowerMode Mode
        {
            get => _mode;
            set => SleepMethod = (_mode = value) switch
            {
                PowerMode.Balanced => BalancedModeSleep,
                PowerMode.High => HighModeSleep,
                PowerMode.Ultra => UltraModeSleep,
                _ => throw new NotImplementedException($"Power mode {value} was not handled.")
            };
        }

        public const byte MinimalDelayBetweenActions = 1;
        public const byte MinimalDelayBetweenLoops = 1;
        const byte TimerResolution = 1;
        static readonly VirtualKeyCode EditKey = VirtualKeyCode.VK_G;
        readonly InputSimulator InputSim = new InputSimulator();
        public bool Running { get; private set; }
        ushort ActionDelay;
        ushort LoopDelay;


        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)] public static extern uint TimeBeginPeriod(uint uMilliseconds);
        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", SetLastError = true)] public static extern uint TimeEndPeriod(uint uMilliseconds);


        public EditClicker(ushort actionDelay, ushort loopDelay, PowerMode mode = PowerMode.Balanced)
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

        void BalancedModeSleep(ushort interval) => Thread.Sleep(interval);

        void HighModeSleep(ushort interval)
        {
            RegularStopwatch.Restart();
            while (RegularStopwatch.Elapsed.Milliseconds < interval) { }
        }

        void UltraModeSleep(ushort interval)
        {
            int intervalInMicros = interval * 1000;
            MicroStopwatch.Restart();
            while (MicroStopwatch.ElapsedMicroseconds < intervalInMicros) { }
        }

        // Must use method instead of property, because in other parts of the code a delegate is needed to be passed
        public void ChangeActionDelay(ushort actionDelay) => ActionDelay = actionDelay;
        public void ChangeLoopDelay(ushort loopDelay) => LoopDelay = loopDelay;
    }
}
