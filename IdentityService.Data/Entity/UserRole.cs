namespace IdentityService.Data.Entity
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
