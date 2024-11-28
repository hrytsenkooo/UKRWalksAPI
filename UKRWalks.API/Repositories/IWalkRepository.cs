using UKRWalks.API.Models.Domain;

namespace UKRWalks.API.Repositories
{
    public interface IWalkRepository
    {
        Task<Walk> CreateAsync(Walk walk);
        Task<List<Walk>> GetAllAsync();
    }
}
