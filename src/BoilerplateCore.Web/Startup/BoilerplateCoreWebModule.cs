using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BoilerplateCore.Configuration;
using BoilerplateCore.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace BoilerplateCore.Web.Startup
{
    [DependsOn(
        typeof(BoilerplateCoreApplicationModule), 
        typeof(BoilerplateCoreEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class BoilerplateCoreWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BoilerplateCoreWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(BoilerplateCoreConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<BoilerplateCoreNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(BoilerplateCoreApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BoilerplateCoreWebModule).GetAssembly());
        }
    }
}