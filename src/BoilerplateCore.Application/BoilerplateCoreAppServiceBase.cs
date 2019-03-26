using Abp.Application.Services;

namespace BoilerplateCore
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class BoilerplateCoreAppServiceBase : ApplicationService
    {
        protected BoilerplateCoreAppServiceBase()
        {
            LocalizationSourceName = BoilerplateCoreConsts.LocalizationSourceName;
        }
    }
}