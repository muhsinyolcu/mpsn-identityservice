namespace IdentityService.Business.Dto.Request
{
    public class LoginRequest: BaseRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
