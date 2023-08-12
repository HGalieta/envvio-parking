using AutoMapper;
using Envvio.Parking.Data.Dtos;
using Envvio.Parking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Envvio.Parking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        private UserManager<User> _userManager;

        public UserController(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(CreateUserDto dto)
        {
            User user = _mapper.Map<User>(dto);

            IdentityResult result = await _userManager.CreateAsync(user, dto.Password);

            if (result.Succeeded) return Ok("Usuário cadastrado com sucesso.");

            throw new ApplicationException("Falha ao cadastrar usuário.");
        }
    }
}
