using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateCore.Web.Startup;
namespace BoilerplateCore.Web.Tests
{
    [DependsOn(
        typeof(BoilerplateCoreWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class BoilerplateCoreWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateCoreWebTestModule).GetAssembly());
        }
    }
}