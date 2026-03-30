using ConsoleApp74.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ConsoleApp74.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany()
            .HasForeignKey(o => o.UserId);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Product)
            .WithMany()
            .HasForeignKey(r => r.ProductId);
    }
}