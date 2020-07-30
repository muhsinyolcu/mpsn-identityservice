using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityService.Data.Entity
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
