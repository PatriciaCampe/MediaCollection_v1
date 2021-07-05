using MediaCollection.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaCollection.Repository
{
    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<MediaGenre>()
        //        .HasKey(mg => new { mg.MediaId, mg.GenreId });
        //}


        public DbSet<Media> Media { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Music> Music { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Serie> Series { get; set; }

        public DbSet<Episode> Episodes { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<MediaRole> MediaRoles { get; set; }
        //public DbSet<MediaGenre> MediaGenres { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MusicGenre> MusicGenres { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<SerieGenre> SerieGenres { get; set; }
        public DbSet<PodcastGenre> PodcastGenres { get; set; }

    }
}
