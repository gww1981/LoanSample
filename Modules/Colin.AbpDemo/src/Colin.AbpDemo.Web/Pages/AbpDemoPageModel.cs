using Colin.AbpDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Colin.AbpDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpDemoPageModel : AbpPageModel
    {
        protected AbpDemoPageModel()
        {
            LocalizationResourceType = typeof(AbpDemoResource);
        }
    }
}