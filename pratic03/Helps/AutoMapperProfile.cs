using AutoMapper;
using pratic03.Dtos;
using pratic03.Models;

namespace pratic03.Helps
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
