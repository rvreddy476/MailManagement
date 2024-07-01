using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Repository.Entities
{
    public class OutboundEmail
    {
        public int ID { get; set; }
        public int TemplateID { get; set; }
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }       
        public DateTime SentAt { get; set; }
        public string Status { get; set; }
        public string FailureReason { get; set; }

        public EmailTemplate Template { get; set; }
    }
}
