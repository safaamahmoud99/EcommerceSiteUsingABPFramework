using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EcommerceSite.Data;
using Volo.Abp.DependencyInjection;

namespace EcommerceSite.EntityFrameworkCore
{
    public class EntityFrameworkCoreEcommerceSiteDbSchemaMigrator
        : IEcommerceSiteDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreEcommerceSiteDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the EcommerceSiteDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<EcommerceSiteDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
