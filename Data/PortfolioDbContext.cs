using Microsoft.EntityFrameworkCore;
using DotnetWebAPI.Models;
namespace DotnetWebAPI.Data;

public class PortfolioDbContext : DbContext
{
    public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options)
        : base(options)
    {
    }

    public DbSet<Experience> Experience { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Experience>().HasKey(x => x.exp_id);
        base.OnModelCreating(modelBuilder);
    }
}
