using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Tolo.Abp.ElsaCore.Web
{
    [Dependency(ReplaceServices = true)]
    public class ElsaCoreBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ElsaCore";
    }
}
