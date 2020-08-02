using System;
using System.Collections.Generic;
using System.Text;
using Colin.AbpDemo.Localization;
using Volo.Abp.Application.Services;

namespace Colin.AbpDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpDemoAppService : ApplicationService
    {
        protected AbpDemoAppService()
        {
            LocalizationResource = typeof(AbpDemoResource);
        }
    }
}
