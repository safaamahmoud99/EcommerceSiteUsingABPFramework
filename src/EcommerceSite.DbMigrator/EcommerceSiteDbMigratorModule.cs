using EcommerceSite.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EcommerceSite.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EcommerceSiteEntityFrameworkCoreModule),
        typeof(EcommerceSiteApplicationContractsModule)
        )]
    public class EcommerceSiteDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
