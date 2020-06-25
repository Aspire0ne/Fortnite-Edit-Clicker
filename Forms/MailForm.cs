using EditClicker;
using EditClicker.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortniteAutoclicker
{
    public partial class MailPopup : Form
    {
        readonly TimeSpan DelayBetweenMails = TimeSpan.FromHours(1);
        readonly RadioButton[] SubjectRadioButtons;

        const string GeneralSendingError = "Message could not be sent because there was an error.";
        const string NotEnoughTimePassedError = "Not enough time has passed since the last mail.";
        const string TooLittleCharactersError = "The message is too short.";
        const string SuccesfullySentText = "Message was succesfully sent!";
        const string SendingInProcessText = "Sending...";
        const byte MinimalAmountOfCharacters = 10;



        public MailPopup()
        {
            InitializeComponent();
            FinishComponentInitialization();

            SubjectRadioButtons = new RadioButton[] { BugRadioButton, SuggestionRadioButton, OtherRadioButton };
        }

        void FinishComponentInitialization()
        {
            BackColor = MainForm.GlobalBackColor;
            SendButton.ForeColor = MainForm.GlobalBackColor;

            BugRadioButton.Text = Mail.SubjectType.Bug.ToString();
            SuggestionRadioButton.Text = Mail.SubjectType.Suggestion.ToString();
            OtherRadioButton.Text = Mail.SubjectType.Other.ToString();
        }

        private async void SendButton_ClickAsync(object sender, EventArgs e)
        {
            if (!CanMessageBeSent(out string error))
            {
                if (error != null)
                    InfoLabel.Text = error;
                return;
            }

            InfoLabel.Text = SendingInProcessText;

            Mail.SubjectType subject = SubjectRadioButtons.Single(butt => butt.Checked).Text.ToEnum<Mail.SubjectType>();

            (bool success, Exception ex) result = await Task.Run(() => (Mail.TrySendMail(MessageTextBox.Text, subject, out Exception ex), ex));

            if (result.success)
            {
                InfoLabel.Text = SuccesfullySentText;
                ProgramDataDir.WriteInfo(ProgramDataDir.Line.LastMailTime, DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
            }
            else
                InfoLabel.Text = GeneralSendingError;
        }

        void OnSendButton_FocusLoss(object sender, EventArgs e)
        {
            if (!InfoLabel.Text.Equals(SendingInProcessText))
                InfoLabel.Text = "";
        }

        bool CanMessageBeSent(out string error)
        {
            error = null;

            if (Mail.IsSending)
                return false;

            if (MessageTextBox.TextLength < MinimalAmountOfCharacters)
            {
                error = TooLittleCharactersError;
                return false;
            }

            bool lastMailInfoGotten = ProgramDataDir.TryGetInfo(ProgramDataDir.Line.LastMailTime, out string lastMailTime);
            if (lastMailInfoGotten)
            {
                long currTime = DateTimeOffset.Now.ToUnixTimeSeconds();
                long mailTime = long.Parse(lastMailTime);
                TimeSpan difference = TimeSpan.FromSeconds(currTime - mailTime);
                if (difference < DelayBetweenMails)
                {
                    error = NotEnoughTimePassedError;
                    return false;
                }
            }

            return true;
        }
    }
}
