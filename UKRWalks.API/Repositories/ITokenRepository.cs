using Microsoft.AspNetCore.Identity;

namespace UKRWalks.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
