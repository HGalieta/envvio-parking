using AutoMapper;
using Envvio.Parking.Data.Dtos;
using Envvio.Parking.Models;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;

namespace Envvio.Parking.Services
{
    public class UserService
    {
        private IMapper _mapper;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private TokenService _tokenService;

        public UserService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, TokenService tokenService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task Register(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (!result.Succeeded) throw new ApplicationException("Falha ao cadastrar usuário.");
        }

        public async Task<string>  Login(LoginUserDto dto)
        {
            SignInResult result = await _signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);

            if(!result.Succeeded)
            {
                throw new ApplicationException("Usuário não autentidado.");
            }

            var user = _signInManager
                .UserManager
                .Users
                .FirstOrDefault(u => u.NormalizedUserName == dto.UserName.ToUpper());

            var token = _tokenService.GenerateToken(user);

            return token;
        }
    }
}
