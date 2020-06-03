﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    public partial class Form1 : Form
    {
        readonly string InfoDefaultText;
        const string WaitingForKeyPressText = "Stiskni klávesu...";
        const string PauseButtonPausedText = "Zapnout";
        const string PauseButtonRunningText = "Stopnout";
        readonly KeypressListener listener;
        readonly AutoEditor editor;

        public Form1()
        {
            InitializeComponent();
            StopButt.Text = PauseButtonRunningText;

            editor = new AutoEditor(int.Parse(ActionDelayTextBoxLbl.Text), int.Parse(LoopDelayTextBox.Text));
            listener = new KeypressListener((Keys)TriggerButt.Text[0], editor.ToggleAsynchronously);
            InfoDefaultText = InfoLbl.Text;
        }

        void OnFormLoad(object sender, EventArgs e)
        {
            listener.Subscribe();
        }

        void OnPauseButtonClick(object sender, EventArgs e)
        {
            if (StopButt.Text.Equals(PauseButtonRunningText))
            {
                if (editor.Running)
                    editor.ToggleAsynchronously();
                listener.Unsubscribe();
                StopButt.Text = PauseButtonPausedText;
            }
            else
            {
                StopButt.Text = PauseButtonRunningText;
                listener.Subscribe();
            }
        }


        void OnTriggerButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("trigger button click");
            InfoLbl.Text = WaitingForKeyPressText;
            TriggerButt.Focus();
        }

        void OnTriggerButtonKeyPress(object obj, KeyEventArgs e)
        {
            Console.WriteLine("trigger button press");
            InfoLbl.Text = InfoDefaultText;
            Keys keyCode = e.KeyCode;
            TriggerButt.Text = keyCode.ToString();
            listener.ChangeTrigger(keyCode);
        }

        void OnFormKeypress(object sender, KeyPressEventArgs e)
        {
        }

        // Delay textBoxes.  
        void OnActionDelayTextBoxFocusLoss(object sender, EventArgs e)
            => HandleDelayTextBoxFocusLoss(AutoEditor.MinimalDelayBetweenActions, ActionDelayTextBoxLbl);

        void OnLoopDelayTextBoxFocusLoss(object sender, EventArgs e)
            => HandleDelayTextBoxFocusLoss(AutoEditor.MinimalDelayBetweenLoops, LoopDelayTextBox);

        void OnActionDelayTextBoxTextChange(object sender, EventArgs e)
            => HandleDelayTextboxValueChange(ActionDelayTextBoxLbl, editor.ChangeActionDelay, AutoEditor.MinimalDelayBetweenActions);

        void OnLoopDelayTextBoxTextChange(object sender, EventArgs e)
            => HandleDelayTextboxValueChange(LoopDelayTextBox, editor.ChangeLoopDelay, AutoEditor.MinimalDelayBetweenLoops);


        void HandleDelayTextBoxFocusLoss(int minimalValue, TextBox textbot)
        {
            if (int.Parse(textbot.Text) < minimalValue)
                textbot.Text = minimalValue.ToString();
        }

        void HandleDelayTextboxValueChange(TextBox textbox, Action<int> methodToCall, int minimalValue)
        {
            textbox.Text = new string(textbox.Text.Where(ch => char.IsDigit(ch)).ToArray());

            if (textbox.Text.Length == 0)
                methodToCall.Invoke(minimalValue);
            else
            {
                int delay = int.Parse(textbox.Text);
                methodToCall.Invoke(delay == 0 ? AutoEditor.MinimalDelayBetweenLoops : delay);
            }
        }
    }
}