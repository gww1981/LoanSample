using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Colin.AbpDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpDemoEntityFrameworkCoreModule)
        )]
    public class AbpDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpDemoMigrationsDbContext>();
        }
    }
}
