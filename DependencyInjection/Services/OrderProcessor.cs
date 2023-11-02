using DependencyInjection.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class OrderProcessor
    {
        private readonly IEmailService emailService;

        public OrderProcessor(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        public void ProcessOrder(string customerEmail, string orderDetails)
        {
            // Business logic for processing the order

            // Send an email notification
            emailService.SendEmail(customerEmail, "Order Confirmation", "Your order has been processed.");
        }
    }
}
