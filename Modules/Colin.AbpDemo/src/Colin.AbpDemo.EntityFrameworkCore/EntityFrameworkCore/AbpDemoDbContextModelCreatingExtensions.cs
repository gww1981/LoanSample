using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Colin.AbpDemo.EntityFrameworkCore
{
    public static class AbpDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpDemoConsts.DbTablePrefix + "YourEntities", AbpDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}