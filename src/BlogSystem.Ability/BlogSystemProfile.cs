using AutoMapper;
using BlogSystem.Ability.Docking.Dto;
using BlogSystem.Domain.AccountInfo;

namespace BlogSystemSystem.Ability
{
    public class BlogSystemProfile : Profile
    {
        public BlogSystemProfile()
        {
            CreateMap<User, LoginSuccessDto>();
        }
    }
}
