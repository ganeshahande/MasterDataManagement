
using System.Collections.Generic;
using VFS.Common.Models.AdminMasters;
namespace VFS.Data.EFCore.Manager
{
    public interface IMenuMasterService
    {
        IEnumerable<UserContext> GetMenuMaster(int UserId);
    }
}
