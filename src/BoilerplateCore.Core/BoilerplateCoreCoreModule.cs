using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateCore.Localization;

namespace BoilerplateCore
{
    public class BoilerplateCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            BoilerplateCoreLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateCoreCoreModule).GetAssembly());
        }
    }
}