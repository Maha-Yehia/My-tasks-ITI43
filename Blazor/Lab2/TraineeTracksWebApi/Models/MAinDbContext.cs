using Microsoft.EntityFrameworkCore;
using SharedLibrary;
using System.Diagnostics.Metrics;

namespace TraineeTracksWebApi.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Trainee> Trainees { get; set; }

        public virtual DbSet<Track> Tracks { get; set; }

    }
}
