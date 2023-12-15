using Microsoft.EntityFrameworkCore;
using Server.src.Modules.CreatorModule.Model.Entities;
using Server.src.Modules.OrderModule.Model.Entities;
using Server.src.Modules.ProductModule.Model.Entities;
using Server.src.Modules.UserModule.Model.Entities;

namespace Server.src.Core.Context;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Creator> Creators { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasAlternateKey(e => e.Email);

        modelBuilder.Entity<Product>();

        modelBuilder.Entity<Order>();

        modelBuilder.Entity<Creator>();
    }
}
