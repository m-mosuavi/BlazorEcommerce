using BlazorEcommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product() { Id = 1, Title = "Product 1", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg?20070224000419", Price = 10 },
        new Product() { Id = 2, Title = "Product 2", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. ", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg?20070224000419", Price = 20 },
        new Product() { Id = 3, Title = "Product 3", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,", ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg?20070224000419", Price = 30 }
        );
    }

    public DbSet<Product> Products { get; set; }
}
