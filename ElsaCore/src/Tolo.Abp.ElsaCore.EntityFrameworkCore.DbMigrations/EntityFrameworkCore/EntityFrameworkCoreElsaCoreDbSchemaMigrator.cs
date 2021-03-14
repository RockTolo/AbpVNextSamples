using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tolo.Abp.ElsaCore.Data;
using Volo.Abp.DependencyInjection;

namespace Tolo.Abp.ElsaCore.EntityFrameworkCore
{
    public class EntityFrameworkCoreElsaCoreDbSchemaMigrator
        : IElsaCoreDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreElsaCoreDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ElsaCoreMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ElsaCoreMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}