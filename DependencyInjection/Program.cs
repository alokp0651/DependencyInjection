using DependencyInjection.Email;
using DependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the email service
            IEmailService emailService = new EmailService();

            // Create the order processor and inject the email service
            OrderProcessor orderProcessor = new OrderProcessor(emailService);

            // Process an order
            orderProcessor.ProcessOrder("customer@example.com", "Order details: ...");

            Console.ReadLine();

        }
    }
}
