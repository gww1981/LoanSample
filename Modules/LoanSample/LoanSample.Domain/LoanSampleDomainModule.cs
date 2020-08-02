using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace LoanSample.Domain
{
    [DependsOn(typeof(AbpMultiTenancyModule))]
    public class LoanSampleDomainModule : AbpModule
    {

    }
}
