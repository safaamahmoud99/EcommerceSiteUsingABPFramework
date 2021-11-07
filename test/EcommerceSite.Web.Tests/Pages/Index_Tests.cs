using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace EcommerceSite.Pages
{
    public class Index_Tests : EcommerceSiteWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
