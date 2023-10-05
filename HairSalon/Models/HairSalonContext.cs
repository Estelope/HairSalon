using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists { get; set; }

    public BestRestaurantsContext(DbContextOptions options) : base(options) { }
  }
}