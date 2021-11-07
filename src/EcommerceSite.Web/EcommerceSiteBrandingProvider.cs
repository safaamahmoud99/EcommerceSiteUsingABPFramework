using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace EcommerceSite.Web
{
    [Dependency(ReplaceServices = true)]
    public class EcommerceSiteBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EcommerceSite";
    }
}
