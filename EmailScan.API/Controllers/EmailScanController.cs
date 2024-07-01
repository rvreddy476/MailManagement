using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailScan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailScanController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> EmailScan()
        {
            return Ok();
        }
    }
}
