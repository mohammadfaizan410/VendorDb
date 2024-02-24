using Microsoft.EntityFrameworkCore;

namespace VendorDb.Models
{
    public class VendorContext : DbContext
    {
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public VendorContext(DbContextOptions options) : base(options)
        {

        }
    }
 
}
