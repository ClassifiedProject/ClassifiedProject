using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COREE.Models
{
    public class DbOperator : DbContext
    {
        public DbOperator(DbContextOptions<DbOperator> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbOperator()
        {

        }

        DbSet<Category> Categories { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<District> Districties { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<User>Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-8VTSP7V\\SQLEXPRESS;database=EXCHANGE_APPLICATION");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.PostDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
            });
        }
    }
}
