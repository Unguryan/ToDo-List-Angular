using AutoMapper;
using Tasks.Domain.Models;
using Tasks.EF_Core.Dbo;

namespace Tasks.EF_Core.MapperProfiles
{
    public class TasksProfile : Profile
    {
        public TasksProfile()
        {
            CreateMap<UserDbo, User>()
                .ReverseMap();

            CreateMap<TokenDbo, Token>()
                .ReverseMap();
        }
    }
}
