using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;



namespace MovieLibraryBL
{

    public class MovieLibraryEmail
    {
            private readonly IConfiguration _configuration;

            public MovieLibraryEmail(IConfiguration configuration)
            {
                _configuration = configuration;
            }
        


        public void SendEmail(string name, string userName, string password)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                _configuration["EmailSettings:FromName"],
                _configuration["EmailSettings:FromEmail"]
            ));
            message.To.Add(new MailboxAddress("Account Owner", userName));
            message.Subject = "Movie Library Account Created";
            message.Body = new TextPart("plain")
            {
                Text = "\n\nWelcome to Movie Library\n\n",
            };

            using (var client = new SmtpClient())
            {
                client.Connect(
                    _configuration["EmailSettings:SmtpHost"],
                    int.Parse(_configuration["EmailSettings:SmtpPort"]),
                    SecureSocketOptions.StartTls
                );

                client.Authenticate(
                    _configuration["EmailSettings:Username"],
                    _configuration["EmailSettings:Password"]
                );

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}

