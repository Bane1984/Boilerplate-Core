using Abp.AspNetCore.Mvc.Controllers;

namespace BoilerplateCore.Web.Controllers
{
    public abstract class BoilerplateCoreControllerBase: AbpController
    {
        protected BoilerplateCoreControllerBase()
        {
            LocalizationSourceName = BoilerplateCoreConsts.LocalizationSourceName;
        }
    }
}