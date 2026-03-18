using Microsoft.EntityFrameworkCore;
using BunAndFun.Api.Models;

namespace BunAndFun.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Double Chocolate Cake", Category = "Cakes", Price = 28.50m, ImageUrl = "Images/ChocolateCake.jpg" },
            new Product { Id = 2, Name = "Veggie Club Sandwich", Category = "Sandwiches", Price = 12.99m, ImageUrl = "Images/Vegclubsandwitch.jpeg" },
            new Product { Id = 3, Name = "Almond Croissant", Category = "Pastries", Price = 5.25m, ImageUrl = "Images/Almondcrossiant.jpg" }
        );
    }
}