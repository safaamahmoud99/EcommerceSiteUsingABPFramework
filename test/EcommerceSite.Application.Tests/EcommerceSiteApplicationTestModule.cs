using Volo.Abp.Modularity;

namespace EcommerceSite
{
    [DependsOn(
        typeof(EcommerceSiteApplicationModule),
        typeof(EcommerceSiteDomainTestModule)
        )]
    public class EcommerceSiteApplicationTestModule : AbpModule
    {

    }
}