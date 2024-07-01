using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Management.Models;
using User.Management.User.Interfaces;

namespace OutBoundMail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenService _tokenService;

        public AuthController(IConfiguration configuration, ITokenService tokenService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {

            var token =await _tokenService.GenerateToken(loginModel.UserName);

            if (token == null)
                return Unauthorized();

            return Ok(new { token });

        }
    }
}
