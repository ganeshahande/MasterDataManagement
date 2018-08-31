using System;
using System.Collections.Generic;
using VFS.Common.Models.Masters;

namespace VFS.Common.Models.AdminMasters
{
    public partial class UserMaster
    {
        public UserMaster()
        {
            Country = new HashSet<Country>();
            UserRoleMap = new HashSet<UserRoleMap>();
        }

        public int Id { get; set; }
        public string LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Country> Country { get; set; }
        public ICollection<UserRoleMap> UserRoleMap { get; set; }
    }
}
