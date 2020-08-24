using System;
using System.Collections.Generic;

namespace ForCarcade.Models.SeedData
{
    public static class PaymentsSeedData
    {
        public static List<Payment> GetSeedData()
        {
            return new List<Payment>()
            {
                new Payment() {CustomerId = 1, PaymentDate = new  DateTime(year:2020, month: 6, day: 1, hour: 13, minute: 57, second: 45), Sum = 185},
                new Payment() {CustomerId = 1, PaymentDate = new  DateTime(year:2020, month: 5, day: 14, hour: 16, minute: 34, second: 50), Sum = 30},
                new Payment() {CustomerId = 1, PaymentDate = new  DateTime(year:2020, month: 3, day: 20, hour: 14, minute: 10, second: 1), Sum = 300},

                new Payment() {CustomerId = 2, PaymentDate = new  DateTime(year:2019, month: 6, day: 1, hour: 13, minute: 57, second: 45), Sum = 185},
                new Payment() {CustomerId = 2, PaymentDate = new  DateTime(year:2019, month: 5, day: 14, hour: 16, minute: 34, second: 50), Sum = 30},
                new Payment() {CustomerId = 2, PaymentDate = new  DateTime(year:2019, month: 3, day: 20, hour: 14, minute: 10, second: 1), Sum = 300},
                new Payment() {CustomerId = 2, PaymentDate = new  DateTime(year:2019, month: 5, day: 14, hour: 16, minute: 34, second: 50), Sum = 30},
                new Payment() {CustomerId = 2, PaymentDate = new  DateTime(year:2019, month: 3, day: 20, hour: 14, minute: 10, second: 1), Sum = 300},

                new Payment() {CustomerId = 3, PaymentDate = new  DateTime(year:2016, month: 1, day: 1, hour: 14, minute: 34, second: 52), Sum = 1100},


                new Payment() {CustomerId = 4, PaymentDate = new  DateTime(year:2019, month: 3, day: 17, hour: 20, minute: 57, second: 11), Sum = 10000},
                new Payment() {CustomerId = 4, PaymentDate = new  DateTime(year:2020, month: 6, day: 13, hour: 3, minute: 31, second: 56), Sum = 13},
            };
        }
    }
}