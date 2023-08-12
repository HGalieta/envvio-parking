using Envvio.Parking.Data.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Envvio.Parking.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult RegisterUser(CreateUserDto dto)
        {
            return View();
        }
    }
}
