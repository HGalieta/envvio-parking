using AutoMapper;
using Envvio.Parking.Data.Dtos;
using Envvio.Parking.Models;

namespace Envvio.Parking.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
