using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.AdminMasters
{
    public partial class UserRoleMap
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public RoleMaster Role { get; set; }
        public UserMaster User { get; set; }
    }
}
