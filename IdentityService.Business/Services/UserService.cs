using IdentityService.Business.Dto;
using IdentityService.Business.Dto.Request;
using IdentityService.Business.Dto.Response;
using IdentityService.Business.Interfaces;
using System.Threading.Tasks;

namespace IdentityService.Business.Services
{
    public class UserService : IUserService
    {
        public Task<ServiceResult<UserResponse>> LoginUser(LoginRequest loginRequest)
        {
            throw new System.NotImplementedException();
        }
    }
}
