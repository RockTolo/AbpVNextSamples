using System.Threading.Tasks;

namespace Tolo.Abp.ElsaCore.Data
{
    public interface IElsaCoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
