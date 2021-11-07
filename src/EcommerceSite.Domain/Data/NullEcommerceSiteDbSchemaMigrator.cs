using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EcommerceSite.Data
{
    /* This is used if database provider does't define
     * IEcommerceSiteDbSchemaMigrator implementation.
     */
    public class NullEcommerceSiteDbSchemaMigrator : IEcommerceSiteDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}