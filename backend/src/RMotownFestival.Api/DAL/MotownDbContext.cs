using Microsoft.EntityFrameworkCore;
using RMotownFestival.Api.Domain;

namespace RMotownFestival.Api.DAL
{
    public class MotownDbContext : DbContext
    {
        public MotownDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Stage> Stages { get; set; }
    }
}
