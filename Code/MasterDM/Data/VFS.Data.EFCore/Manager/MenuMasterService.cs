using System;
using System.Collections.Generic;
using VFS.Common.Models.AdminMasters;
using VFS.Data.EFCore.Common;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Http;
namespace VFS.Data.EFCore.Manager
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly ApplicationContext _dbContext;

        public MenuMasterService(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<UserContext> GetMenuMaster(int UserId)
        {
            //SqlParameter parameterS = new SqlParameter("@UserId", UserId);
            var result = _dbContext.UserContext.FromSql("dbo.usp_GetMenu {0}", UserId);            
            return result.ToList();
        }
    }
}
