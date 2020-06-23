using Gma.System.MouseKeyHook;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    class KeypressListener
    {
        public bool MouseClickIsTrigger { get; set; }
        Keys _Trigger;

        public Keys Trigger
        {
            get => _Trigger;
            set
            {
                _Trigger = value;
                IgnoreNextKeyUp = true;
            }
        }

        readonly IKeyboardEvents KeyboardHook;
        readonly IMouseEvents MouseHook;
        readonly EditClicker Clicker;
        bool IgnoreNextKeyUp;
        public bool CheckFortniteState { get; set; } = false;

        public KeypressListener(Keys trigger, EditClicker clicker, bool mouseClickIsTrigger = true)
        {
            MouseClickIsTrigger = mouseClickIsTrigger;
            KeyboardHook = Hook.GlobalEvents();
            MouseHook = Hook.GlobalEvents();
            _Trigger = trigger;
            Clicker = clicker;
        }

        public void StartListening() => SubscribeKeyUp();

        public void StopListening() => UnsubscribeKeyUp();

        #region Subscription methods

        void SubscribeKeyUp() => KeyboardHook.KeyUp += HandleKeyUp;

        void UnsubscribeKeyUp() => KeyboardHook.KeyUp -= HandleKeyUp;

        void SubscribeKeyDown() => KeyboardHook.KeyDown += HandleKeyDown;

        void UnsubscribeKeyDown() => KeyboardHook.KeyDown -= HandleKeyDown;

        void SubscribeMouseUp() => MouseHook.MouseUp += HandleMouseUp;

        void UnsubscribeMouseUp() => MouseHook.MouseUp -= HandleMouseUp;

        #endregion Subscription methods

        void HandleMouseUp(object sender, MouseEventArgs e) => HandleTriggerPress();

        void HandleKeyUp(object sender, KeyEventArgs e) => HandleGeneralKeyPress(e, true);

        void HandleKeyDown(object sender, KeyEventArgs e) => HandleGeneralKeyPress(e, false);

        void HandleGeneralKeyPress(KeyEventArgs e, bool isKeyUp)
        {
            if (_Trigger == e.KeyCode)
            {
                if (CheckFortniteState && !ForegroundProcessMonitor.IsFortniteFocused())
                    return;

                if (IgnoreNextKeyUp && isKeyUp)
                {
                    IgnoreNextKeyUp = false;
                    return;
                }

                HandleTriggerPress();

                if (!isKeyUp)
                    IgnoreNextKeyUp = true;
            }
        }

        void HandleTriggerPress()
        {
            if (Clicker.Running)
            {
                Clicker.Toggle();

                if (MouseClickIsTrigger)
                    UnsubscribeMouseUp();

                UnsubscribeKeyDown();
                SubscribeKeyUp();
            }
            else
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
                    Clicker.Toggle();
                }).Start();

                UnsubscribeKeyUp();
                SubscribeKeyDown();

                if (MouseClickIsTrigger)
                    SubscribeMouseUp();
            }
        }
    }
}
