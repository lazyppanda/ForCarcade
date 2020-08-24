using ForCarcade.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ForCarcade.Infrastructure
{
    public class PaymentsViewModel
    {
        public List<FullPaymentInfo> Payments { get; set; }
        public int PageSize { get; } = 5;
        
        public PaymentsViewModel(string searchPartOfName = "", DateTime searchDate = new DateTime()) 
        {
            using (var context = new CustomersDbContext())
            {            
                var query = context.Payments.Join(context.Customers,
                    payment => payment.CustomerId,
                    customer => customer.CustomerId, 
                    (payment, customer) => new FullPaymentInfo()
                    {
                        Name = customer.CustomerName,
                        Time = payment.PaymentDate,
                        Sum = payment.Sum,
                    });

                if (!string.IsNullOrWhiteSpace(searchPartOfName))
                {
                    query = query.Where(p => p.Name.Contains(searchPartOfName));
                }

                if (searchDate != DateTime.MinValue)
                {
                    query = query.Where(p => p.Time.Day == searchDate.Day &&
                                             p.Time.Month == searchDate.Month &&
                                             p.Time.Year == searchDate.Year);
                }

                Payments = query.ToList();
            }
        }
    }
}