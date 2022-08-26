using Microsoft.EntityFrameworkCore;
using MovieTicketBookingClient.Models;

namespace MovieTicketBookingClient.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorAndMovie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            
            //Defining relation one to many with movie side
            modelBuilder.Entity<ActorAndMovie>().HasOne(m=>m.Movie).WithMany(am =>am.Actors_Movies).HasForeignKey(m=>m.MovieId);

            //Defining relation one to many with Actor side
            modelBuilder.Entity<ActorAndMovie>().HasOne(x => x.Actor).WithMany(y => y.ActorsAndMovies).HasForeignKey(x => x.ActorId);
            //modelBuilder.Entity<Actor_Movie>().HasOne(m=>m.mpv)
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ActorAndMovie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
