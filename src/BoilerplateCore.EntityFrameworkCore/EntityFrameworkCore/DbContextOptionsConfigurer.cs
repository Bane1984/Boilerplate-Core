using Microsoft.EntityFrameworkCore;

namespace BoilerplateCore.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<BoilerplateCoreDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for BoilerplateCoreDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
