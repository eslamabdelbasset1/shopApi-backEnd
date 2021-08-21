using Microsoft.EntityFrameworkCore;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.DBContexts
{
    public class MySqlDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> Orderdetails { get; set; }

        public MySqlDBContext(DbContextOptions<MySqlDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Map entities to tables (Customers) 
            modelBuilder.Entity<Customer>().ToTable("customers");
      

            // Configure Primary Keys  
            modelBuilder.Entity<Customer>().HasKey(ug => ug.CustomerNumber).HasName("customerNumber");


            // Map entities to tables (Orders)
            modelBuilder.Entity<Order>().ToTable("orders");


            // Configure Primary Keys  
            modelBuilder.Entity<Order>().HasKey(ug => ug.OrderNumber).HasName("orderNumber");



            // Map entities to tables (OrdersDetails)
            modelBuilder.Entity<OrderDetail>().ToTable("orderdetails");


            // Configure Primary Keys  
            modelBuilder.Entity<OrderDetail>().HasKey(ug => ug.OrderNumber).HasName("orderNumber");
        }
    }
}   


 
 