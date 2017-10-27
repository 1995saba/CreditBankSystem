using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace AppServices
{
    public class EmailSender
    {
        private string smtpHost;
        private int smtpPort;
        private string smtpUserName;
        private string smtpUserPassword;

        public EmailSender()
        {
            smtpHost = "smtp.gmail.com";
            smtpPort = 587;
            smtpUserName = "162sdp@gmail.com";
            smtpUserPassword = "124578369qwerty";
        }

        public void Send(string email, string messageSubject, string messageBody)
        {
            //Создание подключения
            SmtpClient client = new SmtpClient(smtpHost, smtpPort);
            client.Credentials = new NetworkCredential(smtpUserName, smtpUserPassword);
            client.EnableSsl = true;

            //Создание сообщения
            MailMessage message = new MailMessage(smtpUserName, email, messageSubject, messageBody);

            try
            {
                //Отсылаем сообщение
                client.Send(message);
            }

            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
