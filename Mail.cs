using System;
using System.Net;
using System.Net.Mail;

namespace FortniteAutoclicker
{
    public static class Mail
    {
        const string SubjectBeginning = "[EditClicker] ";
        const bool EnableSsl = true;
        const ushort Port = 587;

        static readonly int Timeout = 15000;
        static readonly MailMessage Message;
        static readonly SmtpClient Client;

        public static bool IsSending { get; private set; }
        public enum SubjectType { Bug, Suggestion, Other }



        static Mail()
        {
            SensitiveMailConstants constants = new SensitiveMailConstants();
            Message = new MailMessage(new string(constants.Sender), new string(constants.Recipient));
            Client = new SmtpClient
            {
                Port = Port,
                Host = new string(constants.Host),
                Credentials = new NetworkCredential(new string(constants.Sender), new string(constants.Password)),
                EnableSsl = EnableSsl,
                Timeout = Timeout
            };

            Console.WriteLine("1");
            constants.ClearInfo();
            constants = null;
            GC.Collect();
        }

        public static bool TrySendMail(string message, SubjectType subjectType, out Exception ex, string replyAddress = "")
        {
            IsSending = true;
            ex = null;
            bool success = true;

            Message.Body = message;
            Message.Subject = SubjectBeginning + subjectType.ToString() + (replyAddress == "" ? "" : $" | From {replyAddress}");

            try
            {
                Client.Send(Message);
            }
            catch (Exception e)
            {
                ex = e;
                success = false;
            }

            IsSending = false;
            return success;
        }
    }
}
