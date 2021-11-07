using EcommerceSite.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EcommerceSite.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class EcommerceSitePageModel : AbpPageModel
    {
        protected EcommerceSitePageModel()
        {
            LocalizationResourceType = typeof(EcommerceSiteResource);
        }
    }
}