using Volo.Abp.Modularity;

namespace Tolo.Abp.ElsaCore
{
    [DependsOn(
        typeof(ElsaCoreApplicationModule),
        typeof(ElsaCoreDomainTestModule)
        )]
    public class ElsaCoreApplicationTestModule : AbpModule
    {

    }
}