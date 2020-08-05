using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace AKH.Portfolio.Blog
{
    public interface IPostAppService : ICrudAppService< //Defines CRUD methods
        PostDto, //Used to show Posts
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdatePostDto> //Used to create/update a book
    {
        
    }
}