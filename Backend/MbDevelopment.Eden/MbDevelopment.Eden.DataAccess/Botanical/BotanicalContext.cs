using MbDevelopment.Eden.Core;
using Microsoft.EntityFrameworkCore;

namespace MbDevelopment.Eden.DataAccess;

public class BotanicalContext(DbContextOptions<BotanicalContext> options) : DbContext(options)
{
    protected override void OnConfiguring(DbContextOptionsBuilder options){}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //SeedTaxonomy(modelBuilder);
    }
    
    public DbSet<Plant> Species { get; set; } = null!;
}