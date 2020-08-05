using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AKH.Portfolio.EntityFrameworkCore
{
    [DependsOn(
        typeof(PortfolioEntityFrameworkCoreModule)
        )]
    public class PortfolioEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PortfolioMigrationsDbContext>();
        }
    }
}
