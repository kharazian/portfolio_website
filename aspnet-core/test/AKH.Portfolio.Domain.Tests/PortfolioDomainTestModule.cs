using AKH.Portfolio.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AKH.Portfolio
{
    [DependsOn(
        typeof(PortfolioEntityFrameworkCoreTestModule)
        )]
    public class PortfolioDomainTestModule : AbpModule
    {

    }
}