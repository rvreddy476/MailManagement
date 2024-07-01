using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OutBoundMail.API.Models;
using OutBoundMail.API.Services.Interfaces;

namespace OutBoundMail.API.Controllers
{
    [ApiController]
    [Route("api/outbound-email")]
    public class OutboundEmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public OutboundEmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]      
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            await _emailService.SendEmailAsync(request.TemplateId, request.Recipient);
            return Ok();
        }
    }
}
