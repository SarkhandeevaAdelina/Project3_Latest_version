using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project3_
{
    internal class ClassMailPassword
    {
        private string senderMeial = "komanda_a_2023@mail.ru";
        private string recipientEmail;
        private string code;

        public ClassMailPassword(string email, string code)
        {
            recipientEmail = email;
            this.code = code;
        }

        public void MailMessag()
        {

            SmtpClient smtpClient = new SmtpClient("smtp.mail.ru");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = true;
            NetworkCredential networkCredential = new NetworkCredential(senderMeial, "6bnqHkGWy6ShpnrHL5wm");
            smtpClient.Credentials = networkCredential;

            MailAddress from = new MailAddress(senderMeial, "Komand");
            MailAddress to = new MailAddress(recipientEmail, "Komand");
            MailMessage message = new MailMessage(from, to);

            MailAddress replyto = new MailAddress(senderMeial);
            message.ReplyToList.Add(replyto);

            message.Subject = code;
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            message.Body = $"<b>Подтверждение почты.</b?<br> <b>{code}</b>.";
            message.BodyEncoding = System.Text.Encoding.UTF8;

            message.IsBodyHtml = true;

            smtpClient.Send(message);
        }
    }
}
