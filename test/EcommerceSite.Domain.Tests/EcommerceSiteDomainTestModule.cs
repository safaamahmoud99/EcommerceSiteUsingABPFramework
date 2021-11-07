using EcommerceSite.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EcommerceSite
{
    [DependsOn(
        typeof(EcommerceSiteEntityFrameworkCoreTestModule)
        )]
    public class EcommerceSiteDomainTestModule : AbpModule
    {

    }
}