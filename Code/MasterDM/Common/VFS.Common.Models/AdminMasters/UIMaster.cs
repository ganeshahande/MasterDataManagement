using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.AdminMasters
{
    public partial class UIMaster
    {
        public UIMaster()
        {
            UIRoleMap = new HashSet<UIRoleMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PageName { get; set; }

        public ICollection<UIRoleMap> UIRoleMap { get; set; }
    }
}
