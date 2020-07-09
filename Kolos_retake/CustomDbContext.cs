using Kolos_retake.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake
{
    public class CustomDbContext : DbContext
    {

        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtMovement> ArtMovements { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Painting> Paintings { get; set; }

        public CustomDbContext()
        {
        }


        public CustomDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
