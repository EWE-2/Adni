using Adni.Application.Common.Interfaces;
using Adni.Application.Dtos.User;
using Microsoft.AspNetCore.Mvc;

namespace Adni.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        public readonly IUserService _userservice;
        public UsersController(IUserService userService) => _userservice = userService;

        [HttpPost("auth")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest model)
        {
            var response = _userservice.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Le nom d'utilisateur ou le mot de passe incorrecte" });

            return Ok(response);
        }
    }
}
