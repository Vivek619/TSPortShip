using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TS.Models.Models;

namespace TS.Persistence.DB
{
    public class TSDBContext : DbContext
    {
        public virtual DbSet<Port> Ports { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TSPortSystem;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Port>().HasData(
                new Port { ID = 1, Name = "Port 1", Latitude = 90, Longitude = 100 },
                new Port { ID = 2, Name = "Port 2", Latitude = 120, Longitude = 130 },
                new Port { ID = 3, Name = "Port 3", Latitude = 70, Longitude = 150 }
            );
            modelBuilder.Entity<Ship>().HasData(
                new Ship { ID = 1, Name = "Ship 1", Latitude = 20, Longitude = 30 },
                new Ship { ID = 2, Name = "Ship 2", Latitude = 40, Longitude = 25 },
                new Ship { ID = 3, Name = "Ship 3", Latitude = 26, Longitude = 57 }
            );
        }
    }
}
