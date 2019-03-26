using BoilerplateCore.Configuration;
using BoilerplateCore.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BoilerplateCore.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class BoilerplateCoreDbContextFactory : IDesignTimeDbContextFactory<BoilerplateCoreDbContext>
    {
        public BoilerplateCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BoilerplateCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(BoilerplateCoreConsts.ConnectionStringName)
            );

            return new BoilerplateCoreDbContext(builder.Options);
        }
    }
}