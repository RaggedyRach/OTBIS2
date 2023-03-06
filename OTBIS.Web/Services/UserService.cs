using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OTBIS.Web.Data;
using OTBIS.Web.Areas.Identity;

namespace OTBIS.Web.Services
{
    public class UserService
    {
        #region Property
        private readonly ApplicationDbContext _ApplicationDbContext;

        #endregion

        #region Constructor
        public UserService(ApplicationDbContext applicationDbContext)
        {
            _ApplicationDbContext = applicationDbContext;
        }
        #endregion
        #region Get All User Roles
        public async Task<List<IdentityRole>> GetAllUserRoles()
        {
            var userRoles = await (from db in _ApplicationDbContext.Roles
                                   select db).ToListAsync();
            return userRoles; 
        }
        #endregion

        
    }
}
