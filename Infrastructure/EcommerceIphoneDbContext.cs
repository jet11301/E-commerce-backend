using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class EcommerceIphoneDbContext:DbContext
    {
        public DbSet<Slideshows> Slideshows { get; set; }
        public DbSet<StaffAccounts> StaffAccounts { get; set; }

        public DbSet<CustomerAddresses> CustomerAddresses { get; set; }

        public DbSet<Customers> Customers { get; set; }
        public EcommerceIphoneDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .HasOne(c => c.Customer_addresses)
                .WithOne(a => a.Customers)
                .HasForeignKey<CustomerAddresses>(a => a.Id);
        }
    }
}
