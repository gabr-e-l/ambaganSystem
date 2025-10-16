using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbaganBusinessDataLogic
{
    public class EmailService
    {
        
        public static void SendNewListEmail(string listName, double setAmount)
        {
            
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Ambagan System", "from@example.com"));
            message.To.Add(new MailboxAddress("Treasurer", "me@example.com")); // receiver’s email
            message.Subject = $"New Ambagan List Created: {listName}";

            message.Body = new TextPart("plain")
            {
                Text = $"A new list named '{listName}' has been created.\n" +
                        $"Set amount: ₱{setAmount}\n\n" +
                        $"Date Created: {DateTime.Now}"
            };

            using (var client = new SmtpClient())
            {
                var smtpHost = "sandbox.smtp.mailtrap.io";
                var smtpPort = 2525;
                var tsl = MailKit.Security.SecureSocketOptions.StartTls;
                client.Connect(smtpHost, smtpPort, tsl);

                var userName = "a746e4e9e918e6";
                var password = "49af5fe819edd7";

                client.Authenticate(userName, password);

                client.Send(message);
                client.Disconnect(true);
            }


        }


    }
}
