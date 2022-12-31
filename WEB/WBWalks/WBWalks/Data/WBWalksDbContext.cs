using Microsoft.EntityFrameworkCore;
using WBWalks.Models.Domain;

namespace WBWalks.Data
{
    public class WBWalksDbContext : DbContext
    {
        public WBWalksDbContext(DbContextOptions<WBWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set;}

    }
}
