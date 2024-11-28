using Microsoft.EntityFrameworkCore;
using UKRWalks.API.Data;
using UKRWalks.API.Models.Domain;

namespace UKRWalks.API.Repositories
{
    public class SQLWalkRepository : IWalkRepository
    {
        private readonly UKRWalksDbContext dbContext;

        public SQLWalkRepository(UKRWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Walk> CreateAsync(Walk walk)
        {
            await dbContext.Walks.AddAsync(walk);
            await dbContext.SaveChangesAsync();
            return walk;
        }

        public async Task<List<Walk>> GetAllAsync()
        {
            return await dbContext.Walks.ToListAsync();
        }
    }
}
