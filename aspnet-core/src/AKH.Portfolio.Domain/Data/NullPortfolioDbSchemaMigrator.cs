using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AKH.Portfolio.Data
{
    /* This is used if database provider does't define
     * IPortfolioDbSchemaMigrator implementation.
     */
    public class NullPortfolioDbSchemaMigrator : IPortfolioDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}