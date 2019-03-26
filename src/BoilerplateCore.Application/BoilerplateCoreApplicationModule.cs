using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerplateCore
{
    [DependsOn(
        typeof(BoilerplateCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BoilerplateCoreApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateCoreApplicationModule).GetAssembly());
        }
    }
}