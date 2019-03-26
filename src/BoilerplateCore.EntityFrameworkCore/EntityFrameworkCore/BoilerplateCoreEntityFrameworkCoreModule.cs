using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace BoilerplateCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(BoilerplateCoreCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class BoilerplateCoreEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateCoreEntityFrameworkCoreModule).GetAssembly());
        }
    }
}