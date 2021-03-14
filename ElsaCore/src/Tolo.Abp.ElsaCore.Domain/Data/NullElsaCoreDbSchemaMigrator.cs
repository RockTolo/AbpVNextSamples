using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Tolo.Abp.ElsaCore.Data
{
    /* This is used if database provider does't define
     * IElsaCoreDbSchemaMigrator implementation.
     */
    public class NullElsaCoreDbSchemaMigrator : IElsaCoreDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}