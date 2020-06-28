using Haze.Core.Infra.Data.Common;
using System.Net;
using System.Net.Mail;

namespace Haze.Core.Web.Services
{
    public static class EmailService
    {
        private static MailMessage CreateMail(string from, string to, string subject, string body)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(from),
                Subject = subject,
                Body = body,
            };

            mailMessage.To.Add(to);
            return mailMessage;
        }

        public static void SendMail(string to, string subject, string body)
        {
            var mailMessage = CreateMail(Config.EmailSettings.Email, to, subject, body);
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(Config.EmailSettings.Email, Config.EmailSettings.Password),
                EnableSsl = true
            };

            smtpClient.Send(mailMessage);
        }
    }
}
