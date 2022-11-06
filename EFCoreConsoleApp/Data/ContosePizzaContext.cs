using System;
using EFCoreConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp.Data
{
    public class ContosePizzaContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Get the connection string pattern from : https://learn.microsoft.com/en-us/ef/core/
            optionsBuilder.UseSqlServer("Server=localhost;Database=EFCore;User Id=sa;Password=xxxx123");
        }
    }
}

