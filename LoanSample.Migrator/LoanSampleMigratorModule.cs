using LoanSample.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LoanSample.Migrator
{
    [DependsOn(typeof(LoanSampleDomainModule))]
    [DependsOn(typeof(AbpAutofacModule))]
    public class LoanSampleMigratorModule :AbpModule
    {

    }
}
