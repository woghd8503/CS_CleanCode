﻿using System.Net.Mail;

namespace CleanCode.Comments
{
    public class Comments
    {
        private int _pf; // pay frequency
        private DbContext _dbContext;

        public Comments()
        {
            _dbContext = new DbContext();
        }

        // Returns list of customers in a country.
        public List<Customer> GetCustomers(int countryCode)
        {
            //TODO: We need to get rid of abcd once we revisit this method. Currently, it's
            // creating a coupling between x and y and because of that we're not able to do
            // xyz.

            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            // Save order to the database
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();

            // Send an email to the customer
            var client = new SmtpClient();
            var message = new MailMessage("noreply@site.com", order.Customer.Email, "Your order was successfully placed.", ".");
            client.Send(message);

        }
    }

    public class DbContext { }

}
