using System.Threading.Tasks;
using DotNetDating.API.Models;

namespace DotNetDating.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}