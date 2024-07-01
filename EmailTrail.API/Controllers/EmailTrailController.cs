using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailTrail.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailTrailController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> EmailTrail()
        {
            return Ok();
        }
    }
}
