using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecart_CRUD.Models
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<Cart> Cart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Products>()
                .HasData(
                new Products() {
                    ProductId = 1,
                    ProductName = "Oil",
                    ProductDetails = "Grocery",
                    ProductPrice = 200
                },
                 new Products() {
                     ProductId = 2,
                     ProductName = "apple",
                     ProductDetails = "Fruit",
                     ProductPrice = 40
                 },
                new Products() {
                    ProductId = 3,
                    ProductName = "Beans",
                    ProductDetails = "Veggie",
                    ProductPrice = 24
                });
            modelBuilder.Entity<Cart>()
                .HasData(
                new Cart() {
                    CartId = 1,
                    CartItem = "Flowers",
                    ProductId = 1
                },
                  new Cart() {
                      CartId = 2,
                      CartItem = "Boucket",
                      ProductId = 1
                  },
                   new Cart() {
                       CartId = 3,
                       CartItem = "Bisket",
                       ProductId = 3
                   });

            base.OnModelCreating(modelBuilder);
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options) {
            Database.EnsureCreated();
        }
    }
}
