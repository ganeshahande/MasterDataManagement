using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.AdminMasters
{
    public partial class RoleMaster
    {
        public RoleMaster()
        {
            UIRoleMap = new HashSet<UIRoleMap>();
            UserRoleMap = new HashSet<UserRoleMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<UIRoleMap> UIRoleMap { get; set; }
        public ICollection<UserRoleMap> UserRoleMap { get; set; }
    }
}
