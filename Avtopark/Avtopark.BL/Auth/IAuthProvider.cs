using Avtopark.BL.Auth.Entities;

namespace Avtopark.BL.Auth
{
    public interface IAuthProvider
    {
        Task<TokensResponse> AuthorizeUser(string email, string password);
        Task RegisterUser(string email, string password);
    }
}
