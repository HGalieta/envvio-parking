using AutoMapper;
using Envvio.Parking.Data.Dtos;

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
