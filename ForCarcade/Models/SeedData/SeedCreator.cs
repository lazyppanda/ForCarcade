using System.Data.Entity.Migrations;
using System.Linq;

namespace ForCarcade.Models.SeedData
{
    public static class SeedCreator
    {
        public static bool HaveDataInDb()
        {
            using (var dbContext = new CustomersDbContext())
            {
                if (dbContext.Customers.Any())
                {
                    return true;
                }
            }

            return false;
        }

        public static void SeedData()
        {
            using (var dbContext = new CustomersDbContext())
            {
                if (!dbContext.Customers.Any() && !dbContext.Payments.Any())
                {
                    dbContext.Customers.AddRange(CustomersSeedData.GetSeedData());
                    dbContext.Payments.AddRange(PaymentsSeedData.GetSeedData());

                    dbContext.SaveChanges();
                }
            }
        }

        public static void PrepareDb()
        {
            if (!HaveDataInDb())
            {
                SeedData();
            }
        }
    }
}