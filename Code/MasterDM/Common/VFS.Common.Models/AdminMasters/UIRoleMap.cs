
namespace VFS.Common.Models.AdminMasters
{
    public partial class UIRoleMap
    {
        public int Id { get; set; }
        public int Uiid { get; set; }
        public int RoleId { get; set; }

        public RoleMaster Role { get; set; }
        public UIMaster Ui { get; set; }
    }
}
