using MailKit.Net.Smtp;
using MimeKit;

namespace MovieLibraryEmail
{

    public class MLEmail
    {
        public void SendEmail(string name, string userName, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Movie Library", "do-not-reply@atm.com"));
            message.To.Add(new MailboxAddress("User", "user@example.com")); message.Subject = "Email";
            {
                message.Body = new TextPart("plain")
                {
                    Text = "\n\nWelcome to Movie Library\n\n",

                };
                using (var client = new SmtpClient())
                {
                    var smtpHost = "sandbox.smtp.mailtrap.io";
                    var smtpPort = 2525;
                    var tls = MailKit.Security.SecureSocketOptions.StartTls;
                    client.Connect(smtpHost, smtpPort, tls);
                    var Username = "78f1ab03312350";
                    var Password = "3a571065eb5241";
                    
                    client.Authenticate(Username, Password);
                    client.Send(message); 
                    client.Disconnect(true);
                }
            }
        }
    }
}
