using MbDevelopment.Eden.Core.Botanical;
using Microsoft.EntityFrameworkCore;

namespace MbDevelopment.Eden.DataAccess.Botanical;

public class BotanicalContext(DbContextOptions<BotanicalContext> options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //SeedTaxonomy(modelBuilder);
    }
    
    public DbSet<Plant> Plants { get; set; } = null!;
    public DbSet<PlantTaxonomy> Taxonomies { get; set; } = null!;
}