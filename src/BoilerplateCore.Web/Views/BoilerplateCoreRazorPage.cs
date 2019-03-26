using Abp.AspNetCore.Mvc.Views;

namespace BoilerplateCore.Web.Views
{
    public abstract class BoilerplateCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected BoilerplateCoreRazorPage()
        {
            LocalizationSourceName = BoilerplateCoreConsts.LocalizationSourceName;
        }
    }
}
