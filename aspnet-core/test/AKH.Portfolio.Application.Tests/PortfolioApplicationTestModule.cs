using Volo.Abp.Modularity;

namespace AKH.Portfolio
{
    [DependsOn(
        typeof(PortfolioApplicationModule),
        typeof(PortfolioDomainTestModule)
        )]
    public class PortfolioApplicationTestModule : AbpModule
    {

    }
}