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

            modelBuilder.Entity<Artist>(mb =>
            {
                mb.HasKey(a => a.IdArtist);
                mb.Property(a => a.FirstName);
                mb.Property(a => a.DateOfBirth);
                mb.Property(a => a.City);

                mb.ToTable("Artist");
            });

            modelBuilder.Entity<City>(mb =>
            {
                mb.HasKey(a => a.IdCity);
                mb.Property(a => a.Name);
                mb.Property(a => a.Population);

                mb.ToTable("City");
            });

            modelBuilder.Entity<Painting>(mb =>
            {
                mb.HasKey(a => a.IdArtist);
                mb.Property(a => a.IdCoAuthor);
                mb.Property(a => a.IdPainting);
                mb.Property(a => a.PaintingMedia);
                mb.Property(a => a.SurfaceType);

                mb.ToTable("Painting");
            });

            modelBuilder.Entity<ArtMovement>(mb =>
            {
                mb.HasKey(a => a.IdArtMovement);
                mb.Property(a => a.IdMovementFounder);
                mb.Property(a => a.IdNextArtMovement);
                mb.Property(a => a.Name);
                mb.Property(a => a.Founder);

                mb.ToTable("ArtMovement");
            });
        }
    }
}
