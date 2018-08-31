using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.Masters
{
    public partial class User
    {
        public User()
        {
            Country = new HashSet<Country>();
            //MstuserRoleMapping = new HashSet<MstuserRoleMapping>();
        }

        public int Id { get; set; }
        public string LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Country> Country { get; set; }
        //public ICollection<MstuserRoleMapping> MstuserRoleMapping { get; set; }
    }
}
