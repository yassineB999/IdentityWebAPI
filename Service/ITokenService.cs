using Application.Models;

namespace Application.Service
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
