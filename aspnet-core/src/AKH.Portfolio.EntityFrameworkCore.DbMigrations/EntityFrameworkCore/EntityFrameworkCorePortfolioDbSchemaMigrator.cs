using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AKH.Portfolio.Data;
using Volo.Abp.DependencyInjection;

namespace AKH.Portfolio.EntityFrameworkCore
{
    public class EntityFrameworkCorePortfolioDbSchemaMigrator
        : IPortfolioDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePortfolioDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PortfolioMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PortfolioMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}