using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EcommerceSite.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class EcommerceSiteDbContextFactory : IDesignTimeDbContextFactory<EcommerceSiteDbContext>
    {
        public EcommerceSiteDbContext CreateDbContext(string[] args)
        {
            EcommerceSiteEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<EcommerceSiteDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new EcommerceSiteDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../EcommerceSite.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
