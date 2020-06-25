using EditClicker.Extensions;
using FortniteAutoclicker;
using System;
using System.Drawing;
using System.Windows.Forms;
using static EditClicker.EditClicker;

namespace EditClicker
{
    public partial class MainForm : Form
    {
        public static readonly Color GlobalBackColor = Color.FromArgb(62, 63, 65);
        const string InfoDefaultText = "";
        const string WaitingForKeyPressText = "Press a key...";
        const string PauseButtonPausedText = "Unpause";
        const string PauseButtonRunningText = "Pause";
        readonly KeypressListener listener;
        readonly EditClicker clicker;

        public MainForm()
        {
            InitializeComponent();
            FinishComponentInitialization();

            clicker = new EditClicker(
                actionDelay: ushort.Parse(ActionDelayTextBox.Text),
                loopDelay: ushort.Parse(LoopDelayTextBox.Text),
                mode: PowerModeMenu.Text.ToEnum<PowerMode>());

            listener = new KeypressListener(
                trigger: (Keys)TriggerButt.Text[0],
                clicker: clicker,
                mouseClickIsTrigger: MouseClickTurnsOffCheckBox.Checked,
                checkFortniteState: CheckIfFortniteRunning_CheckBox.Checked,
                triggerMode: TriggerTypeToggleRadioBox.Checked ? KeypressListener.TriggerMode.Toggle : KeypressListener.TriggerMode.Hold);
        }

        void FinishComponentInitialization()
        {
            ActiveControl = InfoLbl;
            StopButt.Text = PauseButtonRunningText;
            BackColor = GlobalBackColor;

            foreach (var mode in (PowerMode[])Enum.GetValues(typeof(PowerMode)))
                PowerModeMenu.Items.Add(mode.ToString());

            PowerMode normalMode = PowerMode.Normal;
            PowerModeMenu.Text = normalMode.ToString();
            toolTip1.SetToolTip(PowerModeMenu, normalMode.GetEnumDescription());
        }

        void OnFormLoad(object sender, EventArgs e) => listener.StartListening();

        void OnPauseButton_Click(object sender, EventArgs e)
        {
            if (StopButt.Text.Equals(PauseButtonRunningText))
            {
                if (clicker.Running)
                    clicker.Toggle();
                listener.StopListening();
                StopButt.Text = PauseButtonPausedText;
            }
            else
            {
                StopButt.Text = PauseButtonRunningText;
                listener.StartListening();
            }
        }

        void OnKeyMapperButton_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = WaitingForKeyPressText;
            (sender as Button).Focus();
            listener.IgnoreNextKeyUp = true;
        }

        Keys OnKeyMapperButton_KeyPress(object sender, KeyEventArgs e)
        {
            InfoLbl.Text = InfoDefaultText;
            InfoLbl.Focus();
            Keys key = e.KeyCode;
            (sender as Button).Text = key.ToString();
            return key;
        }

        void OnTriggerButton_KeyPress(object obj, KeyEventArgs e)
        {
            Keys key = OnKeyMapperButton_KeyPress(obj, e);
            listener.Trigger = key;
        }

        void OnEditKeyButton_KeyPress(object obj, KeyEventArgs e)
        {
            Keys key = OnKeyMapperButton_KeyPress(obj, e);
            clicker.EditKey = (WindowsInput.Native.VirtualKeyCode)key;
        }

        private void OnTurnOffWithLeftClickCheckBox_CheckedChange(object sender, EventArgs e)
            => listener.MouseClickIsTrigger = MouseClickTurnsOffCheckBox.Checked;

        #region Delay textboxes

        void OnActionDelayTextBox_FocusLoss(object sender, EventArgs e)
            => HandleDelayTextBoxFocusLoss(EditClicker.MinimalDelayBetweenActions, ActionDelayTextBox);

        void OnLoopDelayTextBox_FocusLoss(object sender, EventArgs e)
            => HandleDelayTextBoxFocusLoss(EditClicker.MinimalDelayBetweenLoops, LoopDelayTextBox);

        void OnActionDelayTextBox_TextChange(object sender, EventArgs e)
            => HandleDelayTextboxValueChange(ActionDelayTextBox, clicker.ChangeActionDelay, EditClicker.MinimalDelayBetweenActions);

        void OnLoopDelayTextBox_TextChange(object sender, EventArgs e)
            => HandleDelayTextboxValueChange(LoopDelayTextBox, clicker.ChangeLoopDelay, EditClicker.MinimalDelayBetweenLoops);

        void HandleDelayTextBoxFocusLoss(int minimalValue, TextBox textbot)
        {
            bool parsed = int.TryParse(textbot.Text, out int value);
            if (!parsed || value < minimalValue)
                textbot.Text = minimalValue.ToString();
        }

        void HandleDelayTextboxValueChange(TextBox textbox, Action<ushort> methodToCall, byte minimalValue)
        {
            for (int i = 0; i < textbox.Text.Length; ++i)
                if (!char.IsDigit(textbox.Text[i]))
                {
                    textbox.Text = textbox.Text.Remove(i, 1);
                    if (i != 0)
                        textbox.Select(i, 0);
                    break;
                }

            if (textbox.Text.Length == 0)
                methodToCall.Invoke(minimalValue);
            else
            {
                ushort delay = ushort.Parse(textbox.Text);
                methodToCall.Invoke(delay == 0 ? EditClicker.MinimalDelayBetweenLoops : delay);
            }
        }

        #endregion Delay textboxes

        private void OnPowerModeMenuComboBox_ItemChange(object sender, EventArgs e)
        {
            if (clicker != null)
            {
                string item = PowerModeMenu.SelectedItem.ToString();
                PowerMode itemAsPowerMode = item.ToEnum<PowerMode>();
                string description = itemAsPowerMode.GetEnumDescription();
                toolTip1.SetToolTip(PowerModeMenu, description);
                clicker.Mode = itemAsPowerMode;
            }
        }

        private void OnFortniteRunningCheckCheckBox_CheckedChange(object sender, EventArgs e)
        {
            listener.CheckFortniteState = CheckIfFortniteRunning_CheckBox.Checked;
        }

        private void OnTriggerTypeToggleRadioBox_CheckedChange(object sender, EventArgs e)
        {
            listener.Mode = KeypressListener.TriggerMode.Toggle;
        }

        private void OnTriggerTypeHoldRadioBox_CheckedChange(object sender, EventArgs e)
        {
            listener.Mode = KeypressListener.TriggerMode.Hold;
        }

        private void OnMailPictureBox_Clicked(object sender, EventArgs e)
        {
            new MailPopup().Show();
        }
    }
}
