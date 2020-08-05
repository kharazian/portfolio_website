using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace AKH.Portfolio.Blog
{
    public class BlogDataSeedContributor: IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Post, int> _postRepository;

        public BlogDataSeedContributor(IRepository<Post, int> postRepository)
        {
            _postRepository = postRepository;
        }
        
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _postRepository.GetCountAsync() <= 0)
            {
                await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "1984",
                        Content = "This is a test Post 1"
                    },
                    autoSave: true
                );

                await _postRepository.InsertAsync(
                    new Post
                    {
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Content = "This is a test Post 2"
                    },
                    autoSave: true
                );
            }
        }
    }
}