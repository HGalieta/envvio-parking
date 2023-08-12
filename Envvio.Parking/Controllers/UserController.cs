using Envvio.Parking.Data.Dtos;
using Envvio.Parking.Services;
using Microsoft.AspNetCore.Mvc;

namespace Envvio.Parking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService registerService)
        {
            _userService = registerService;            
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(CreateUserDto dto)
        {
            await _userService.Register(dto);
            return Ok("Usuário cadastrado com sucesso.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto dto)
        {
            var token = await _userService.Login(dto);
            return Ok(token);

        }
    }
}
