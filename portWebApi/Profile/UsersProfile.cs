namespace portWebApi.Profile
{
    public class UsersProfile : AutoMapper.Profile
    {
        public UsersProfile()
        {
            CreateMap<Models.Domain.User, Models.Dtos.User>()
                .ReverseMap();

            CreateMap<Models.Domain.Ocupation, Models.Dtos.Ocupation>()
                .ReverseMap();

            CreateMap<Models.Domain.TechnicalSkills, Models.Dtos.TechnicalSkills>()
                .ReverseMap();

            CreateMap<Models.Domain.SoftSkills, Models.Dtos.SoftSkills>()
                .ReverseMap();

            CreateMap<Models.Domain.Location, Models.Dtos.Location>()
                .ReverseMap();

            CreateMap<Models.Domain.Education, Models.Dtos.Education>()
                .ReverseMap();

            CreateMap<Models.Domain.WorkHistory, Models.Dtos.WorkHistory>()
                .ReverseMap();

            CreateMap<Models.Domain.Social, Models.Dtos.Social>()
                .ReverseMap();

            CreateMap<Models.Domain.Languages, Models.Dtos.Languages>()
                .ReverseMap();

            CreateMap<Models.Domain.Trajectory, Models.Dtos.Trajectory>()
                .ReverseMap();

            CreateMap<Models.Domain.Posts, Models.Dtos.Posts>()
                .ReverseMap();
        }
    }
}
