using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace AKH.Portfolio.Blog
{
    public class PostAppService : CrudAppService<
            Post, //The Book entity
            PostDto, //Used to show Posts
            int, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdatePostDto>, //Used to create/update a book
        IPostAppService //implement the IBookAppService
    {
        public PostAppService(IRepository<Post, int> repository)
            : base(repository)
        {

        }
        
    }
}