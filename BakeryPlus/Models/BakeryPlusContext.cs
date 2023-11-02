using Microsoft.EntityFrameworkCore;

namespace BakeryPlus.Models
{
  public class BakeryPlusContext : DbContext
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }

    public BakeryPlusContext(DbContextOptions options) : base(options) {}
  }
}