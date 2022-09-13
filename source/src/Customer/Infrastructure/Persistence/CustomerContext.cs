namespace CarRent.Customer.Infrastructure.Persistence
{
    using CarRent.Customer.Domain;
    using Microsoft.EntityFrameworkCore;
    using System.Runtime.CompilerServices;
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(
                x =>
                {
                    x.HasKey(y => y.CustomerNumber);
                    x.Property(y => y.Firstname);
                    x.Property(y => y.Lastname);
                    x.Property(y => y.Street);
                    x.Property(y => y.StreetNumber);
                    x.Property(y => y.City);
                    x.Property(y => y.ZipCode);
                    x.Property(y => y.Country);
                }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
