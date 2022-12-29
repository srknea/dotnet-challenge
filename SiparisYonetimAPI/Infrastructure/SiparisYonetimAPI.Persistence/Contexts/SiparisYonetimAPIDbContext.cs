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
        
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }
    }
}
