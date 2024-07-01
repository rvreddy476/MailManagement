using Mail.Repository.Repository.Interfaces;
using OutBoundMail.API.Services.Interfaces;


namespace OutBoundMail.API.Services.Implementations
{
    public class EmailService : IEmailService
    {


        private readonly IEmailService _emailService;
        private readonly IEmailOutboundRepository _emailOutboundRepository;
       

        public EmailService(IEmailOutboundRepository emailOutboundRepository)
        {         
            _emailOutboundRepository = emailOutboundRepository;           
        }

        public async Task SendEmailAsync(string templateId, string recipient)
        {
            var template = await _emailOutboundRepository.GetTemplateAsync(int.Parse(templateId));
            var uniqueId = Guid.NewGuid().ToString();
            var subject = $"{template.SubjectTemplate} [{uniqueId}]";
            var body = template.BodyTemplate;

            /////////send email logic 

            

           
        }

    }
}
