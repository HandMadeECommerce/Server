using Microsoft.EntityFrameworkCore;
using Server.src.Modules.CreatorModule.Model.Entities;
using Server.src.Modules.OrderModule.Model.Entities;
using Server.src.Modules.ProductModule.Model.Entities;
using Server.src.Modules.User.Model.Entities;

namespace Server.src.Core.Context;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {

    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Creator> Creators { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>();
        modelBuilder.Entity<Product>();
        modelBuilder.Entity<Order>();
        modelBuilder.Entity<Creator>();
    }
}
