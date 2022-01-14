using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace AlarmClock.Helper
{
    public class SMTPService
    {
        /// <summary>
        /// 發送Email
        /// </summary>
        /// <param name="email">收件者</param>
        /// <param name="subject">主旨</param>
        /// <param name="body">內文</param>
        public bool SendEmail(string email, string subject, string body)
        {
            string Account = "testing@gmail.com";
            string Password = "test123";

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new NetworkCredential(Account, Password);
            client.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(Account);
            mail.To.Add(email);
            mail.Subject = subject;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Body = body;
            mail.BodyEncoding = Encoding.UTF8;

            try
            {
                client.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                mail.Dispose();
                client.Dispose();
            }
        }
    }
}
