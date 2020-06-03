using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace FortniteAutoclicker
{
    class AutoEditor
    {
        enum ClickType { Left, Right }
        public const byte MinimalDelayBetweenActions = 5;
        public const byte MinimalDelayBetweenLoops = 10;
        static readonly VirtualKeyCode EditKey = VirtualKeyCode.VK_G;
        readonly InputSimulator InputSim = new InputSimulator();
        public bool Running { get; private set; }
        int ActionDelay;
        int LoopDelay;



        public AutoEditor(int delay, int newLoopDelay)
        {
            ActionDelay = delay;
            LoopDelay = newLoopDelay;
        }

        public void ToggleAsynchronously()
        {
            if (Running)
                Running = false;
            else
            {
                Running = true;
                new Thread(() => { Thread.CurrentThread.Priority = ThreadPriority.AboveNormal; StartEditing(); }).Start();
            }
        }

        void StartEditing()
        {
            while (Running)
            {
                ClickInEditMode(ClickType.Left);
                ExecuteLoopDelay();
            }

            InputSim.Mouse.LeftButtonUp();
            ClickInEditMode(ClickType.Right);
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
        void Sleep(int interval) => Thread.Sleep(interval);

        public void ChangeActionDelay(int actionDelay) => ActionDelay = actionDelay;
        public void ChangeLoopDelay(int loopDelay) => LoopDelay = loopDelay;
    }
}
