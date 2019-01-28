using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IceSkool.Controllers
{
    public abstract class IceSkoolControllerBase: AbpController
    {
        protected IceSkoolControllerBase()
        {
            LocalizationSourceName = IceSkoolConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
