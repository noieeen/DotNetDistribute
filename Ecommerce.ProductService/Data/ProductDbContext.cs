using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Model;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "AA", Price = 20, Quantity = 100 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "BB", Price = 20, Quantity = 200 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "CC", Price = 20, Quantity = 300 });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
