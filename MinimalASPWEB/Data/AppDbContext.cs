using Microsoft.EntityFrameworkCore;
using MinimalASPWEB.Models;
using System.Collections.Generic;
namespace MinimalASPWEB.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            base.OnModelCreating(modelBuilder);
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Produtos = new DbSet<Product>();
        }
    }
}
