using FortniteAutoclicker.Src;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace FortniteAutoclicker
{
    class EditClicker
    {
        enum ClickType { Left, Right }
        public const byte MinimalDelayBetweenActions = 1;
        public const byte MinimalDelayBetweenLoops = 1;
        const byte TimerResolution = 1;
        static readonly VirtualKeyCode EditKey = VirtualKeyCode.VK_G;
        readonly InputSimulator InputSim = new InputSimulator();
        readonly MicroStopwatch Stopwatch = new MicroStopwatch();
        public bool Running { get; private set; }
        ushort ActionDelay;
        ushort LoopDelay;


        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)] public static extern uint TimeBeginPeriod(uint uMilliseconds);
        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", SetLastError = true)] public static extern uint TimeEndPeriod(uint uMilliseconds);


        public EditClicker(ushort actionDelay, ushort loopDelay)
        {
            ActionDelay = actionDelay;
            LoopDelay = loopDelay;
        }

        public void Toggle()
        {
            if (Running)
            {
                TimeEndPeriod(TimerResolution);
                Running = false;
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
                ExecuteLoopDelay();
            }

            ClickInEditMode(ClickType.Right);
            InputSim.Mouse.LeftButtonUp();
            Stopwatch.Stop();
        }

        void ClickInEditMode(ClickType click)
        {
            PressEditKey();
            ExecuteActionDelay();

            if (click == ClickType.Left)
                InputSim.Mouse.LeftButtonDown();
            else
                InputSim.Mouse.RightButtonClick();

            ExecuteActionDelay();
            PressEditKey();
        }

        void PressEditKey() => InputSim.Keyboard.KeyPress(EditKey);

        void ExecuteActionDelay() => Sleep(ActionDelay);

        void ExecuteLoopDelay() => Sleep(LoopDelay);

        void Sleep(ushort interval)
        {
            Thread.Sleep(interval);
        }

        public void ChangeActionDelay(ushort actionDelay) => ActionDelay = actionDelay;
        public void ChangeLoopDelay(ushort loopDelay) => LoopDelay = loopDelay;
    }
}
