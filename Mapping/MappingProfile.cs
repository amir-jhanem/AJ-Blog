using AJ_Blog.Controllers.Resources;
using AJ_Blog.Core.Models;
using AutoMapper;

namespace AJ_Blog.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap(typeof(QueryResult<>), typeof(QueryResultResource<>));
            CreateMap<Post, SavePostResource>();
            CreateMap<Post, PostResource>();
            // API Resource to Domain
            CreateMap<PostQueryResource, PostQuery>();
            CreateMap<SavePostResource, Post>()
                .ForMember(v=>v.Id , opt=>opt.Ignore());
        }
    }
}