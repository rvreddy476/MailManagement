using Mail.Repository.DBContext;
using Mail.Repository.Entities;
using Mail.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Mail.Repository.Repository.Implementations
{
    public class EmailOutboundRepository : IEmailOutboundRepository
    {
        private readonly EmailDbContext _context;
        public EmailOutboundRepository(EmailDbContext context)
        {
            _context = context;
        }
        public async Task<EmailTemplate> GetTemplateAsync(int templateId)
        {
            return await _context.EmailTemplates.Where(x => x.TemplateID == templateId).FirstOrDefaultAsync();
        }

        public async Task AddOutBoundMail(OutboundEmail outboundEmail)
        {
            _context.OutboundEmails.Add(outboundEmail);
            await _context.SaveChangesAsync();
        }
    }
}
