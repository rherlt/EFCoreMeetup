﻿using Microsoft.EntityFrameworkCore;

namespace _02_Performance.EFCore
{
    internal class AdventureWorksDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorksDb"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
            
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
            
        //    modelBuilder.Entity<Customer>().ToTable("Sales.Customer");
        //}
    }
}