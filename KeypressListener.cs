using Gma.System.MouseKeyHook;
using System;
using System.Windows.Forms;

namespace FortniteAutoclicker
{

    class KeypressListener
    {
        Keys Trigger;
        readonly Action MethodToInvoke;
        readonly IKeyboardEvents KeyboardHook;


        public KeypressListener(Keys trigger, Action methodToInvoke)
        {
            KeyboardHook = Hook.GlobalEvents();
            Trigger = trigger;
            MethodToInvoke = methodToInvoke;
        }

        public void ChangeTrigger(Keys newTrigger) => Trigger = newTrigger;

        public void Subscribe() => KeyboardHook.KeyUp += GlobalHookKeyPress;
        public void Unsubscribe() => KeyboardHook.KeyUp -= GlobalHookKeyPress;

        void GlobalHookKeyPress(object sender, KeyEventArgs e)
        {
            if (Trigger == e.KeyCode && ProcessMonitor.IsFortniteFocused())
                MethodToInvoke.Invoke();
        }
    }
}
