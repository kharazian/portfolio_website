using AKH.Portfolio.Blog;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AKH.Portfolio.EntityFrameworkCore
{
    public static class PortfolioDbContextModelCreatingExtensions
    {
        public static void ConfigurePortfolio(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PortfolioConsts.DbTablePrefix + "YourEntities", PortfolioConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            
            builder.Entity<Post>(b =>
            {
                b.ToTable("Posts");
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Title).IsRequired().HasMaxLength(128);
            });
        }
    }
}