using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Tolo.Abp.ElsaCore.Pages
{
    public class Index_Tests : ElsaCoreWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
