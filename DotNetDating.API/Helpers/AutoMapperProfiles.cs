using AutoMapper;
using DotNetDating.API.Dtos;
using DotNetDating.API.Models;

namespace DotNetDating.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailedDto>();
        }
    }
}