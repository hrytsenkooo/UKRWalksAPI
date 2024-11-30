using UKRWalks.API.Models.Domain;

namespace UKRWalks.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
