using System;
using System.Threading.Tasks;
using Abp.TestBase;
using BoilerplateCore.EntityFrameworkCore;
using BoilerplateCore.Tests.TestDatas;

namespace BoilerplateCore.Tests
{
    public class BoilerplateCoreTestBase : AbpIntegratedTestBase<BoilerplateCoreTestModule>
    {
        public BoilerplateCoreTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BoilerplateCoreDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerplateCoreDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BoilerplateCoreDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerplateCoreDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BoilerplateCoreDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerplateCoreDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BoilerplateCoreDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerplateCoreDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
