using Tolo.Abp.ElsaCore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Tolo.Abp.ElsaCore.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ElsaCoreEntityFrameworkCoreDbMigrationsModule),
        typeof(ElsaCoreApplicationContractsModule)
        )]
    public class ElsaCoreDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
