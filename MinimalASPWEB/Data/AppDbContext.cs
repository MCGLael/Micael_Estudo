using Microsoft.EntityFrameworkCore;
using MinimalASPWEB.Models;
using System.Collections.Generic;
namespace MinimalASPWEB.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Produtos { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
    }
}
