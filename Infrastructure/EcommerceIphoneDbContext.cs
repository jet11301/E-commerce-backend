using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class EcommerceIphoneDbContext:DbContext
    {
        public DbSet<Slideshows> Slideshows { get; set; }
        public DbSet<StaffAccounts> StaffAccounts { get; set; }

        public EcommerceIphoneDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
