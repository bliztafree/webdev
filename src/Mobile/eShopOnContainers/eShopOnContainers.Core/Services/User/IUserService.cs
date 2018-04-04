using bliztafree.Core.Models.User;
using System.Threading.Tasks;

namespace bliztafree.Core.Services.User
{
    public interface IUserService
    {
        Task<UserInfo> GetUserInfoAsync(string authToken);
    }
}
