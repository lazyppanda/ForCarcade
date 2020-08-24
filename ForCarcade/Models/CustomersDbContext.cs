using System.Data.Entity;

namespace ForCarcade.Models
{
    public partial class CustomersDbContext : DbContext
    {
        public CustomersDbContext()
            : base("name=CustomersDbContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
