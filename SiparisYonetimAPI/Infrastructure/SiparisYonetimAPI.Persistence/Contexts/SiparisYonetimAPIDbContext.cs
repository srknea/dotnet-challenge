using Microsoft.EntityFrameworkCore;
using SiparisYonetimAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimAPI.Persistence.Contexts
{
    public class SiparisYonetimAPIDbContext : DbContext
    {
        public SiparisYonetimAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Firm> Firms { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Order>()
                .HasOne(c => c.Firm)
                .WithMany(d => d.Orders)
                .HasForeignKey(c => c.FirmId)
                



            modelBuilder.Entity<Order>()
                .HasOne(c => c.Product)
                .WithMany(d => d.Orders)
                .HasForeignKey(c => c.ProductId);
            */
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
    }
}
