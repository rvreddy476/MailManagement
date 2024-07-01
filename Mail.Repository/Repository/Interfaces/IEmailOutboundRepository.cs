using Mail.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Repository.Repository.Interfaces
{
    public interface IEmailOutboundRepository
    {
        Task<EmailTemplate> GetTemplateAsync(int templateId);
        Task AddOutBoundMail(OutboundEmail outboundEmail);
    }
}
