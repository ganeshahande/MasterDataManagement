using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.AdminMasters
{
    public partial class UserContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PageName { get; set; }

        public bool IsEditable { get; set; }
    }
}
