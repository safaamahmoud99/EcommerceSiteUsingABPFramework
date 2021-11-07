using System.Threading.Tasks;

namespace EcommerceSite.Data
{
    public interface IEcommerceSiteDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
