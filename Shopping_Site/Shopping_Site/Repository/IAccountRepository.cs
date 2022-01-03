using Microsoft.AspNetCore.Identity;
using Shopping_Site.Models;
using System.Threading.Tasks;

namespace Shopping_Site.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel);
    }
}