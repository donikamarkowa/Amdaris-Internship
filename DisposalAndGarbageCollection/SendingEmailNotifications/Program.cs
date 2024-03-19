namespace SendingEmailNotifications
{
    using System.Net;
    using System.Net.Mail;
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your email please:");
                string recipientEmail = Console.ReadLine();

                if (string.IsNullOrEmpty(recipientEmail))
                {
                    throw new ArgumentNullException();
                }

                string senderEmail = "emailsendertest11111@gmail.com";
                string senderPass = "uqlr zcor ycgp xlwp";
                string smtpServer = "smtp.gmail.com";
                int port = 587;

                SendEmail(recipientEmail, smtpServer, port, senderEmail, senderPass);

                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while sending the email:");
                Console.WriteLine(ex.Message);
            }
            

        }

        static void SendEmail(string recipientEmail, string smtpServer, int port, string senderEmail, string senderPassword)
        {
            using (SmtpClient smtpClient = new SmtpClient(smtpServer, port))
            {
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(senderEmail);
                    mailMessage.To.Add(recipientEmail);
                    mailMessage.Subject = "Welcome to our newsletter community!";
                    mailMessage.Body = "Thank you for subscribing to our newsletter!";
                    smtpClient.Send(mailMessage);
                }
            }
        }
    }
}
