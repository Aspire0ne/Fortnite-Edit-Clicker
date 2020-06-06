using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    public partial class Form1 : Form
    {
        readonly string InfoDefaultText;
        PictureBox InitialClosePictureBox;
        PictureBox InitialMinimizePictureBox;
        readonly static Color InteractivePictureBoxActiveTint = Color.FromArgb(100, 209, 31, 31);
        const string WaitingForKeyPressText = "Stiskni klávesu...";
        const string PauseButtonPausedText = "Zapnout";
        const string PauseButtonRunningText = "Stopnout";
        readonly KeypressListener listener;
        readonly EditClicker clicker;

        public Form1()
        {
            InitializeComponent();
            StopButt.Text = PauseButtonRunningText;
            InfoDefaultText = InfoLbl.Text;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(62, 63, 65);

            clicker = new EditClicker(ushort.Parse(ActionDelayTextBox.Text), ushort.Parse(LoopDelayTextBox.Text));
            listener = new KeypressListener((Keys)TriggerButt.Text[0], clicker, MouseClickTurnsOffCheckBox.Checked);
            InitialClosePictureBox = MinimizePictureBox;
            InitialMinimizePictureBox = ClosePictureBox;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")] public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void TintPictureBox(PictureBox box)
        {
            Image boxImg = box.Image;
            SolidBrush brush = new SolidBrush(InteractivePictureBoxActiveTint);

            Graphics g = Graphics.FromImage(boxImg);
            g.FillRectangle(brush, 0, 0, boxImg.Width, boxImg.Height);
            box.Invalidate();

            brush.Dispose();
            g.Dispose();
        }


        //TODO: Tint the buttons red
        void OnInteractivePictureBox_MouseEnter(object sender, EventArgs e)
        {
            //if (sender is PictureBox box)
            // TintPictureBox(box);
        }

        void OnInteractivePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("unpainting");
            //   if (sender is PictureBox box)

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
        }

        private void OnTurnOffWithLeftClickCheckBox_CheckedChange(object sender, EventArgs e) => listener.MouseClickIsTrigger = MouseClickTurnsOffCheckBox.Checked;


        // Delay textBoxes.  
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
            if (int.Parse(textbot.Text) < minimalValue)
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

        private void OnClosePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnMinimizePictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
