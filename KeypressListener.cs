using Gma.System.MouseKeyHook;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace EditClicker
{
    class KeypressListener
    {
        public bool MouseClickIsTrigger { get; set; }

        public bool CheckFortniteState { get; set; }

        public bool IgnoreNextKeyUp { set; private get; }

        public Keys Trigger { get; set; }

        TriggerMode _Mode;

        public TriggerMode Mode
        {
            get => _Mode;
            set
            {
                _Mode = value;
                if (value == TriggerMode.Hold && !SubscribedKeys.Contains(SubscriptionType.KeyDown))
                {
                    SubscribeKeyDown();
                }
                else if (SubscribedKeys.Contains(SubscriptionType.KeyDown))
                {
                    UnsubscribeKeyDown();
                }
            }
        }

        public enum TriggerMode { Toggle, Hold }

        enum SubscriptionType { KeyUp, KeyDown, MouseUp }

        bool HoldingTrigger;
        readonly HashSet<SubscriptionType> SubscribedKeys = new HashSet<SubscriptionType>(2);
        readonly IKeyboardEvents KeyboardHook = Hook.GlobalEvents();
        readonly IMouseEvents MouseHook = Hook.GlobalEvents();
        readonly EditClicker Clicker;

        public KeypressListener(Keys trigger, EditClicker clicker, bool mouseClickIsTrigger = true, bool checkFortniteState = false, TriggerMode triggerMode = TriggerMode.Toggle)
        {
            MouseClickIsTrigger = mouseClickIsTrigger;
            CheckFortniteState = checkFortniteState;
            Mode = triggerMode;
            Trigger = trigger;
            Clicker = clicker;
        }

        public void StartListening()
        {
            if (Mode == TriggerMode.Hold)
                SubscribeKeyDown();
            SubscribeKeyUp();
        }

        public void StopListening()
        {
            if (SubscribedKeys.Contains(SubscriptionType.KeyUp))
                UnsubscribeKeyUp();
            if (SubscribedKeys.Contains(SubscriptionType.KeyDown))
                UnsubscribeKeyDown();
        }

        #region Subscription methods

        void SubscribeKeyUp()
        {
            KeyboardHook.KeyUp += HandleKeyUp;
            SubscribedKeys.Add(SubscriptionType.KeyUp);
        }

        void UnsubscribeKeyUp()
        {
            KeyboardHook.KeyUp -= HandleKeyUp;
            SubscribedKeys.Remove(SubscriptionType.KeyDown);
        }

        void SubscribeKeyDown()
        {
            KeyboardHook.KeyDown += HandleKeyDown;
            SubscribedKeys.Add(SubscriptionType.KeyDown);
        }

        void UnsubscribeKeyDown()
        {
            KeyboardHook.KeyDown -= HandleKeyDown;
            SubscribedKeys.Remove(SubscriptionType.KeyDown);
        }

        void SubscribeMouseUp()
        {
            MouseHook.MouseUp += HandleMouseUp;
            SubscribedKeys.Add(SubscriptionType.MouseUp);
        }

        void UnsubscribeMouseUp()
        {
            MouseHook.MouseUp -= HandleMouseUp;
            SubscribedKeys.Remove(SubscriptionType.MouseUp);
        }

        #endregion Subscription methods

        void HandleMouseUp(object sender, MouseEventArgs e) => HandleTriggerPress(true);

        void HandleKeyUp(object sender, KeyEventArgs e) => HandleGeneralKeyPress(e, true);

        void HandleKeyDown(object sender, KeyEventArgs e) => HandleGeneralKeyPress(e, false);

        void HandleGeneralKeyPress(KeyEventArgs e, bool isKeyUp)
        {
            if (Trigger == e.KeyCode)
            {
                if (CheckFortniteState && !FortniteMonitor.IsFortniteFocused())
                    return;

                bool wasHoldingTrigger = HoldingTrigger;

                if (isKeyUp)
                {
                    if (IgnoreNextKeyUp)
                    {
                        IgnoreNextKeyUp = false;
                        return;
                    }

                    if (HoldingTrigger)
                    {
                        HoldingTrigger = false;
                    }
                }

                if (HoldingTrigger)
                    return;

                if (Mode == TriggerMode.Hold && !wasHoldingTrigger)
                    HoldingTrigger = true;

                HandleTriggerPress(false);
            }
        }

        void HandleTriggerPress(bool mouse)
        {
            if (Clicker.Running)
            {
                Clicker.Toggle();
                if (Mode == TriggerMode.Toggle && !mouse)
                    IgnoreNextKeyUp = true;

                ChangeSubscriptionsEditEnded();
            }
            else
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
                    Clicker.Toggle();
                }).Start();

                ChangeSubscriptionsEditStarted();
            }
        }

        void ChangeSubscriptionsEditStarted()
        {
            if (Mode == TriggerMode.Toggle)
            {
                UnsubscribeKeyUp();
                SubscribeKeyDown();

                if (MouseClickIsTrigger)
                    SubscribeMouseUp();
            }
        }

        void ChangeSubscriptionsEditEnded()
        {
            if (Mode == TriggerMode.Toggle)
            {
                if (MouseClickIsTrigger)
                    UnsubscribeMouseUp();

                UnsubscribeKeyDown();
                SubscribeKeyUp();
            }
        }
    }
}
