using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dollop.Models;

namespace Dollop.Api.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext (DbContextOptions<CoreContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MediaAlbum>()
                .HasKey(m => new { m.AlbumId, m.MediaItemId });
            modelBuilder.Entity<MediaAlbum>()
                .HasOne(a => a.Album)
                .WithMany(a => a.MediaAlbum)
                .HasForeignKey(a => a.AlbumId);

            modelBuilder.Entity<MediaAlbum>()
                .HasOne(m => m.MediaItem)
                .WithMany(m => m.MediaAlbums)
                .HasForeignKey(m => m.MediaItemId);
        }

        public DbSet<Dollop.Models.User> User { get; set; }

        public DbSet<Dollop.Models.MediaItem> Media { get; set; }

        public DbSet<Dollop.Models.Album> Album { get; set; }
    }
}
