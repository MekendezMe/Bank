using AutoMapper;
using BankCoreAPI.Core;
using BankCoreAPI.Core.Models;
using BankCoreAPI.Core.Repositories;
using BankCoreAPI.DTOs.User;
using BankCoreAPI.Interfaces;
using BankCoreAPI.Responses;
using BankCoreAPI.Utils;

namespace BankCoreAPI.Services
{
    public class UserService : IUserService
    {

        private readonly UserRepository _userRepository;
        private IMapper _mapper;

        public UserService(ApplicationDbContext context, IMapper mapper) 
        {
            _userRepository = new UserRepository(context);
            _mapper = mapper;
        }

        public async Task<ResponseType<UserDTO>> RegisterAsync(RegisterDTO candidate)
        {
            ResponseType<UserDTO> response = new ResponseType<UserDTO>();

            if (string.IsNullOrEmpty(candidate.Email) || string.IsNullOrEmpty(candidate.Name)
                || string.IsNullOrEmpty(candidate.Password))
            {
                response.Error = "Required fields not filled";
                return response;
            }

            User? user = await _userRepository.GetUserByEmailAsync(candidate.Email);

            if (user is not null)
            {
                response.Error = "User with input email exist";
                return response;
            }

            PasswordEncryptionService passwordEncryptionService = new PasswordEncryptionService();

            string hashPassword = passwordEncryptionService.HashPassword(candidate.Password);

            User convertedUser = _mapper.Map<User>(candidate);

            User? newUser = await _userRepository.AddAsync(convertedUser);

            response.Data = _mapper.Map<UserDTO>(newUser);

            return response;
        }

        public async Task<ResponseType<UserDTO>> LoginAsync(LoginDTO candidate)
        {
            ResponseType<UserDTO> response = new ResponseType<UserDTO>();

            if (string.IsNullOrEmpty(candidate.Email) || string.IsNullOrEmpty(candidate.Password))
            {
                response.Error = "Required fields not filled";
                return response;
            }

            User? user = await _userRepository.GetUserByEmailAsync(candidate.Email);

            if (user is null)
            {
                response.Error = "User with input email does not exist";
                return response;
            }

            PasswordEncryptionService passwordEncryptionService = new PasswordEncryptionService();

            if (!passwordEncryptionService.VerifyPassword(candidate.Password, user.HashPassword))
            {
                response.Error = "Incorrect email/password";
                return response;
            }

            response.Data = _mapper.Map<UserDTO>(user);

            return response;
        }

        public Task<ActionResponse> ChangePasswordByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResponse> ConfirmEmailByIdAsync(long id)
        {
            throw new NotImplementedException();
        } 

        public Task<ActionResponse> ResetPasswordByEmailAsync(ResetPasswordDTO data)
        {
            throw new NotImplementedException();
        }
    }
}
