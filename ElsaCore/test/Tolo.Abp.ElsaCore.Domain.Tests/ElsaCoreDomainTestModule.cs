using Tolo.Abp.ElsaCore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tolo.Abp.ElsaCore
{
    [DependsOn(
        typeof(ElsaCoreEntityFrameworkCoreTestModule)
        )]
    public class ElsaCoreDomainTestModule : AbpModule
    {

    }
}