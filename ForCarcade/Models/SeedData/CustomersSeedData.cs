using System.Collections.Generic;

namespace ForCarcade.Models.SeedData
{
    public static class CustomersSeedData
    {
        public static List<Customer> GetSeedData()
        {
            return new List<Customer>()
            {
                new Customer() { CustomerName = "ООО \"Рога И Копыта\""},
                new Customer() { CustomerName = "ЗАО \"Колхоз и вилы\""},
                new Customer() { CustomerName = "ИП \"Иванов\""},
                new Customer() { CustomerName = "ООО \"Братки\""},
            };
        }
    }
}