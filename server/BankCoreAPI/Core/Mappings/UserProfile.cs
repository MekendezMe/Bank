using AutoMapper;
using BankCoreAPI.Core.Models;
using BankCoreAPI.DTOs.User;

namespace BankCoreAPI.Core.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<RegisterDTO, User>();
            CreateMap<LoginDTO, User>();
        }
    }
}
