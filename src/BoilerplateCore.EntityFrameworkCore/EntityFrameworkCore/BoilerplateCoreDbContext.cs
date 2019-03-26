using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoilerplateCore.EntityFrameworkCore
{
    public class BoilerplateCoreDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public BoilerplateCoreDbContext(DbContextOptions<BoilerplateCoreDbContext> options) 
            : base(options)
        {

        }
    }
}
