using Microsoft.EntityFrameworkCore;

namespace Task_Day09.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
            
        }

        public DbSet<Track> tracks { get; set; }
        public DbSet<Trainee> trainees { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}
