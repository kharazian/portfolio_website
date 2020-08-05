using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AKH.Portfolio.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PortfolioMigrationsDbContextFactory : IDesignTimeDbContextFactory<PortfolioMigrationsDbContext>
    {
        public PortfolioMigrationsDbContext CreateDbContext(string[] args)
        {
            PortfolioEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PortfolioMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new PortfolioMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
