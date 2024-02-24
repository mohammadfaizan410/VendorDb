namespace VendorDb.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public String Username { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }

        public List<Listing> Listings { get; set; }
    }
}
