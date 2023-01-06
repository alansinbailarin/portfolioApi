using AutoMapper;

namespace portWebApi.Profile
{
    public class UsersProfile : AutoMapper.Profile
    {
        public UsersProfile()
        {
            CreateMap<Models.Domain.User, Models.Dtos.User>()
                .ReverseMap();
        }
    }
}
