using Abp.EntityFrameworkCore;
using BoilerplateCore.Models;
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

        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Kancelarija> Kancelarije { get; set; }
        public DbSet<Uredjaj> Uredjaji { get; set; }
        public DbSet<UredjajUzetVracen> UredjajUzetVraceni { get; set; }
    }
}
