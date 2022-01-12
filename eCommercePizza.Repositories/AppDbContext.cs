using eCommercePizza.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace eCommercePizza.Repositories
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
    {
        //need for migration
        public AppDbContext()
        {

        }
        // configs from my settings
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }


        //need for migration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    //optionsBuilder.UseSqlServer(@"Server=IZZET;initial catalog=eCommercePizzaDB;Trusted_Connection=True;");
            //}
            base.OnConfiguring(optionsBuilder);
        }
    }
}
