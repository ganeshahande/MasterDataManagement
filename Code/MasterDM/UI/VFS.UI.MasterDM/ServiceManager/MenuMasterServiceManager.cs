using System.Linq;
using System.Collections.Generic;
using VFS.Common.Models.AdminMasters;
using VFS.Data.EFCore.Manager;
using Microsoft.AspNetCore.Http;


namespace VFS.UI.MasterDM.ServiceManager
{
    public class MenuMasterServiceManager : IMenuMasterServiceManager
    {
        private IMenuMasterService _menuMasterService = null;

        public MenuMasterServiceManager(IMenuMasterService MenuMasterService) => _menuMasterService = MenuMasterService;
        public IEnumerable<UserContext> GetMenuMaster(int UserId)
        {
            var result = _menuMasterService.GetMenuMaster(UserId);            
            return result.ToList();
        }
    }
}
