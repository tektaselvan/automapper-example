using AutoMapper;
using automapper_example.DTOs;
using automapper_example.Models;

namespace automapper_example.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
