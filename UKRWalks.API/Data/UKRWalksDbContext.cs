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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficuilties = new List<Difficulty>()
            {
                new Difficulty
                {
                    Id = Guid.Parse("3BFD4E70-9D17-4A45-85E6-BAC5EFF4FB6D"),
                    Name = "Easy"
                },
                new Difficulty
                {
                    Id = Guid.Parse("51EF0D6A-2C24-4C04-A626-4125AA2A2DC4"),
                    Name = "Medium"
                },
                new Difficulty
                {
                    Id = Guid.Parse("609C4904-E7F2-4A96-97DA-6EE03E4E0A1A"),
                    Name = "Hard"
                }
            };

            modelBuilder.Entity<Difficulty>().HasData(difficuilties);

            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.Parse("80530B8C-CE14-4895-8EDC-4BF20E86A460"),
                    Name = "Kyiv",
                    Code = "UA-KY",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Kyiv_%28oblast%29_in_Ukraine.svg/1200px-Kyiv_%28oblast%29_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("34D44F1E-4747-45BB-9F1B-F5F2F450F10A"),
                    Name = "Lviv",
                    Code = "UA-LV",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Lviv_in_Ukraine.svg/1200px-Lviv_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("3EA8EA23-CC61-4C60-A4CD-84E3A261B2BF"),
                    Name = "Odesa",
                    Code = "UA-OD",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e1/Odessa_in_Ukraine.svg/1200px-Odessa_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("3550E2E4-37CD-40A7-AEED-57FA6F6FC328"),
                    Name = "Kharkiv",
                    Code = "UA-KH",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Kharkiv_in_Ukraine.svg/1200px-Kharkiv_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("D3BAB1CC-3C75-4B79-BB25-1C9118404E27"),
                    Name = "Dnipro",
                    Code = "UA-DP",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Dnipropetrovsk_in_Ukraine.svg/1200px-Dnipropetrovsk_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("779139D1-9DB8-4C4C-A71F-E320193C7D57"),
                    Name = "Vinnytsia",
                    Code = "UA-VN",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Vinnytsia_in_Ukraine.svg/1200px-Vinnytsia_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("CF973BC0-4E43-4025-B65A-6FABB66AE76C"),
                    Name = "Zaporizhzhia",
                    Code = "UA-ZP",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Zaporizhia_in_Ukraine.svg/1200px-Zaporizhia_in_Ukraine.svg.png"
                },
                new Region
                {
                    Id = Guid.Parse("9FE6971E-E9C3-454F-906C-0D20B10D108C"),
                    Name = "Ivano-Frankivsk",
                    Code = "UA-IF",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Ivano-Frankivsk_in_Ukraine.svg/275px-Ivano-Frankivsk_in_Ukraine.svg.png"
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
