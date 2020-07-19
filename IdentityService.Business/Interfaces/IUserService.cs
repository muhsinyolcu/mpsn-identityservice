using IdentityService.Business.Dto;
using IdentityService.Business.Dto.Request;
using IdentityService.Business.Dto.Response;
using System.Threading.Tasks;

namespace IdentityService.Business.Interfaces
{
    public interface IUserService : IBusinessUnit
    {
        Task<ServiceResult<UserResponse>> LoginUser(LoginRequest loginRequest);
    }
}
