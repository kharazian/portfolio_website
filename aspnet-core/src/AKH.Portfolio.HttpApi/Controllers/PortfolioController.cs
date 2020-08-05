using AKH.Portfolio.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AKH.Portfolio.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PortfolioController : AbpController
    {
        protected PortfolioController()
        {
            LocalizationResource = typeof(PortfolioResource);
        }
    }
}