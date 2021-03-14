using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Tolo.Abp.ElsaCore.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ElsaCoreMigrationsDbContextFactory : IDesignTimeDbContextFactory<ElsaCoreMigrationsDbContext>
    {
        public ElsaCoreMigrationsDbContext CreateDbContext(string[] args)
        {
            ElsaCoreEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ElsaCoreMigrationsDbContext>()
                .UseSqlite(configuration.GetConnectionString("Default"));

            return new ElsaCoreMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Tolo.Abp.ElsaCore.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
