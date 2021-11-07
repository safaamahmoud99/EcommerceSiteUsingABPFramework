using System;
using System.Collections.Generic;
using System.Text;
using EcommerceSite.Localization;
using Volo.Abp.Application.Services;

namespace EcommerceSite
{
    /* Inherit your application services from this class.
     */
    public abstract class EcommerceSiteAppService : ApplicationService
    {
        protected EcommerceSiteAppService()
        {
            LocalizationResource = typeof(EcommerceSiteResource);
        }
    }
}
