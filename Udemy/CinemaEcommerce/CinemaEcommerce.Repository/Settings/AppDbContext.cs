using CinemaEcommerce.DataModels.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEcommerce.Repository.Settings
{
    public class AppDbContext: DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options): base (options)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>().HasKey(
                    am => new
                    {
                        am.ActorId,
                        am.MovieId
                    }
                );

            modelBuilder.Entity<ActorMovie>().HasOne(m => m.Movie).WithMany(am => am.ActorsMovies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<ActorMovie>().HasOne(a => a.Actor).WithMany(am => am.ActorsMovies).HasForeignKey(a => a.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<ActorMovie>Actors_Movies { get; set; }
    }
}
