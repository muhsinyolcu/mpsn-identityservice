using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityService.Data.Entity
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        [ForeignKey("RoleId")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
