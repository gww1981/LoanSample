using LoanSample.Domain;
using LoanSample.EntityFrameworkCore.Migration;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LoanSample.Migrator
{
    [DependsOn(typeof(LoanSampleDomainModule))]
    [DependsOn(typeof(AbpAutofacModule))]
    [DependsOn(typeof(LoanSampleEntityFrameworkCoreMigrationModule))]
    public class LoanSampleMigratorModule :AbpModule
    {

    }
}
