using System;
using System.Drawing;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    public partial class Form1 : Form
    {
        readonly string InfoDefaultText = "";
        const string WaitingForKeyPressText = "Stiskni klávesu...";
        const string PauseButtonPausedText = "Zapnout";
        const string PauseButtonRunningText = "Pozastavit";
        readonly KeypressListener listener;
        readonly EditClicker clicker;

        public Form1()
        {
            InitializeComponent();
            StopButt.Text = PauseButtonRunningText;
            BackColor = Color.FromArgb(62, 63, 65);

            foreach (var mode in (EditClicker.PowerMode[])Enum.GetValues(typeof(EditClicker.PowerMode)))
                PowerModeMenu.Items.Add(mode.ToString());

            PowerModeMenu.Text = EditClicker.PowerMode.Normal.ToString();

            clicker = new EditClicker(ushort.Parse(ActionDelayTextBox.Text), ushort.Parse(LoopDelayTextBox.Text));
            listener = new KeypressListener((Keys)TriggerButt.Text[0], clicker, MouseClickTurnsOffCheckBox.Checked);
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

        void OnTriggerButton_Click(object sender, EventArgs e)
        {
            InfoLbl.Text = WaitingForKeyPressText;
            TriggerButt.Focus();
        }

        void OnTriggerButton_KeyPress(object obj, KeyEventArgs e)
        {
            InfoLbl.Text = InfoDefaultText;
            Keys keyCode = e.KeyCode;
            TriggerButt.Text = keyCode.ToString();
            listener.Trigger = keyCode;
            InfoLbl.Focus();
        }

        private void OnTurnOffWithLeftClickCheckBox_CheckedChange(object sender, EventArgs e) => listener.MouseClickIsTrigger = MouseClickTurnsOffCheckBox.Checked;

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

        private void OnPowerModeMenu_ItemChange(object sender, EventArgs e)
        {
            if (!(clicker is null))
            {
                string item = PowerModeMenu.SelectedItem.ToString();
                EditClicker.PowerMode itemAsPowerMode = (EditClicker.PowerMode)Enum.Parse(typeof(EditClicker.PowerMode), item);
                clicker.Mode = itemAsPowerMode;
            }
        }

        private void CheckIfFortniteRunning_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            listener.CheckFortniteState = CheckIfFortniteRunning_CheckBox.Checked;
        }
    }
}
