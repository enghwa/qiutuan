using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FargateDemo.Controllers
{
    public abstract class FargateDemoControllerBase: AbpController
    {
        protected FargateDemoControllerBase()
        {
            LocalizationSourceName = FargateDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
