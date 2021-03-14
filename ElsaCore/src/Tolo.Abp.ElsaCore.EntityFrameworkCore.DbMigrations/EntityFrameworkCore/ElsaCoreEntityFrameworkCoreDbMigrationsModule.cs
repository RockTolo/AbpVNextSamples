using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Tolo.Abp.ElsaCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(ElsaCoreEntityFrameworkCoreModule)
        )]
    public class ElsaCoreEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ElsaCoreMigrationsDbContext>();
        }
    }
}
