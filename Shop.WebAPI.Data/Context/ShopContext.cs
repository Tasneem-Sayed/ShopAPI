using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Shop.Domain.Authentication;
using Shop.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Data.Context
{ public class ShopContext : IdentityDbContext<ApplicationUser>
    {
        public ShopContext() {}
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Shipping> shippings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<Upload> Uploads { get; set; }
       public DbSet<CartItem> ShoppingcartItems { get; set; }
        public DbSet<Login> Login { get; set; }

        public DbSet<Register> Register { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }

             base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(c => c.ParentID);

            modelBuilder.Entity<OrderDetails>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(od => od.ProductID);


            modelBuilder.Entity<OrderDetails>()
                .HasOne<Order>()
                .WithMany()
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetails>()
               .HasOne<Shipping>()
               .WithMany()
               .HasForeignKey(od => od.ProductID);

            modelBuilder.Entity<Order>()
               .HasOne<Customer>()
               .WithMany()
               .HasForeignKey(od => od.CustomerID);

            modelBuilder.Entity<Payment>()
               .HasOne<Customer>()
               .WithMany()
               .HasForeignKey(p => p.CustomerNumber);

            //  modelBuilder.Entity<Cart>()
            //     .HasOne<Customer>()
            //     .WithMany()
            //     .HasForeignKey(c => c.CustomerID);

            modelBuilder.Entity<Cart>()
               .HasOne<Product>()
               .WithMany()
               .HasForeignKey(c => c.ProductID);


        }
    }
}
