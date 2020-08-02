using Colin.AbpDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Colin.AbpDemo
{
    [DependsOn(
        typeof(AbpDemoEntityFrameworkCoreTestModule)
        )]
    public class AbpDemoDomainTestModule : AbpModule
    {

    }
}