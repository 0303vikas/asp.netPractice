using AutoMapper;
using PracticeAsp.Net.Dto;
using PracticeAsp.Net.Entity;

namespace PracticeAsp.Net;

class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }
}