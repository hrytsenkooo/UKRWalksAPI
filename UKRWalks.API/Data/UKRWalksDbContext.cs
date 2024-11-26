using Microsoft.EntityFrameworkCore;
using UKRWalks.API.Models.Domain;

namespace UKRWalks.API.Data
{
    public class UKRWalksDbContext : DbContext
    {
        public UKRWalksDbContext(DbContextOptions dbContextOptions) : base (dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
