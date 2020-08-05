using System;
using System.Collections.Generic;
using System.Text;
using AKH.Portfolio.Localization;
using Volo.Abp.Application.Services;

namespace AKH.Portfolio
{
    /* Inherit your application services from this class.
     */
    public abstract class PortfolioAppService : ApplicationService
    {
        protected PortfolioAppService()
        {
            LocalizationResource = typeof(PortfolioResource);
        }
    }
}
