using System.Threading.Tasks;
using BoilerplateCore.Web.Controllers;
using Shouldly;
using Xunit;

namespace BoilerplateCore.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerplateCoreWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
