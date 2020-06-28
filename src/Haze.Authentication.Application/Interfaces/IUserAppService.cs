using Haze.Authentication.Caching.Models;
using Haze.Core.Application.Interfaces;
using System.Threading.Tasks;

namespace Haze.Authentication.Application.Interfaces
{
    public interface IUserAppService : IAppService<UserModel>
    {
        Task<string> Login(UserModel model);
    }
}