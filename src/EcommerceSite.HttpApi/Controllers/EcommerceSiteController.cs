using EcommerceSite.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EcommerceSite.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class EcommerceSiteController : AbpController
    {
        protected EcommerceSiteController()
        {
            LocalizationResource = typeof(EcommerceSiteResource);
        }
    }
}