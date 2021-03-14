using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Tolo.Abp.ElsaCore.EntityFrameworkCore
{
    public static class ElsaCoreDbContextModelCreatingExtensions
    {
        public static void ConfigureElsaCore(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ElsaCoreConsts.DbTablePrefix + "YourEntities", ElsaCoreConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}