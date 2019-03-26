using BoilerplateCore.EntityFrameworkCore;

namespace BoilerplateCore.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BoilerplateCoreDbContext _context;

        public TestDataBuilder(BoilerplateCoreDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}