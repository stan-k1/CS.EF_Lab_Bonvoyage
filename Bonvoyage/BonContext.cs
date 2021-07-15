using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bonvoyage
{
    public class BonContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =localhost; Initial Catalog = Bonvoyage; Integrated Security = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
