using System.Threading.Tasks;

namespace AKH.Portfolio.Data
{
    public interface IPortfolioDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
