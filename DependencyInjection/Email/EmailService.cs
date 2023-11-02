using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Email
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string message)
        {
            Console.WriteLine($"Email sent to: {to}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
