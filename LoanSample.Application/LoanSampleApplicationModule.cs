using LoanSample.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace LoanSample.Application
{

    [DependsOn(typeof(LoanSampleApplicationContractModule))]
    public class LoanSampleApplicationModule : AbpModule
    {

    }
}
