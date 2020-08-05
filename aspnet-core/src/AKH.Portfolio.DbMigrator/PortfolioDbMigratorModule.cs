using AKH.Portfolio.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AKH.Portfolio.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PortfolioEntityFrameworkCoreDbMigrationsModule),
        typeof(PortfolioApplicationContractsModule)
        )]
    public class PortfolioDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
