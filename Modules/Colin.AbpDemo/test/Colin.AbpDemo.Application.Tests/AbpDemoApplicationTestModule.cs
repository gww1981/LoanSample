using Volo.Abp.Modularity;

namespace Colin.AbpDemo
{
    [DependsOn(
        typeof(AbpDemoApplicationModule),
        typeof(AbpDemoDomainTestModule)
        )]
    public class AbpDemoApplicationTestModule : AbpModule
    {

    }
}