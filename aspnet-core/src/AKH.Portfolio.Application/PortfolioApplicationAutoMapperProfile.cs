using AKH.Portfolio.Blog;
using AutoMapper;

namespace AKH.Portfolio
{
    public class PortfolioApplicationAutoMapperProfile : Profile
    {
        public PortfolioApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Post, PostDto>();
            CreateMap<CreateUpdatePostDto, Post>();
        }
    }
}
