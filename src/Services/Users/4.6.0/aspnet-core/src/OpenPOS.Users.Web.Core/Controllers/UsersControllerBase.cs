using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OpenPOS.Users.Controllers
{
    public abstract class UsersControllerBase: AbpController
    {
        protected UsersControllerBase()
        {
            LocalizationSourceName = UsersConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
