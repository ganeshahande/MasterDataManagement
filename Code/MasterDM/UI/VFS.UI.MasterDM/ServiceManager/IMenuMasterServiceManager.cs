using System;
using System.Collections.Generic;
using VFS.Common.Models.AdminMasters;
namespace VFS.UI.MasterDM.ServiceManager
{
    public interface IMenuMasterServiceManager
    {
        IEnumerable<UserContext> GetMenuMaster(int UserId);
    }
}
