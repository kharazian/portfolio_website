using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AKH.Portfolio.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(PortfolioHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class PortfolioConsoleApiClientModule : AbpModule
    {
        
    }
}
