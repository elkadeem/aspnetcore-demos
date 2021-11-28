using Microsoft.EntityFrameworkCore;
using System;

namespace EFDemo
{
    public class CustomDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFDemo2;Integrated Security=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .ToTable("Customers");

            modelBuilder.Entity<Customer>().Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Order>()
                .ToTable("Orders");

            modelBuilder.Entity<Order>()
                .Property(c => c.OrderNo)
                .HasColumnName("OrderNo")
                .HasMaxLength(100)
                .HasDefaultValue(1);

            modelBuilder.Entity<Order>()
                .HasMany(c => c.OrderItems)
                .WithOne()
                .HasForeignKey(c => c.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(c => c.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey("CustomerId");


            modelBuilder.Entity<OrderItem>()
                .HasKey(c => new { c.OrderId, c.Serial });

        }
    }
}
