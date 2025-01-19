
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace TodoApi;

public partial class ToDoDbContext : DbContext
{
    // DbSet של משתמשים
    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
        : base(options)
    {
    }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine("OnConfiguring is being called");

            try
            {
                // var connectionString = "Server=bujkixbbtsdssxnmdyuu-mysql.services.clever-cloud.com;User=uftyv7t4ctoqb2rx;Password=tC6pwbqLIWAI1c7MSb88;Database=bujkixbbtsdssxnmdyuu;";
                var connectionString = Environment.GetEnvironmentVariable("ToDoDB");

                optionsBuilder.UseMySql(connectionString, Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));
                Console.WriteLine("Database connection success");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Database connection failed: {ex.Message}");
                throw; // Optionally rethrow for further handling
            }
        }
    // אפיון טבלאות ותכונות
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        // הגדרת טבלת Items
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("items");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        // הגדרת טבלת Users (למשתמשים)
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Username).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Password).HasMaxLength(255).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
