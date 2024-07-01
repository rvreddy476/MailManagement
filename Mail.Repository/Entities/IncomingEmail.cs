using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Repository.Entities
{
    public class IncomingEmail
    {
        public int ID { get; set; }
        public string SenderEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime ReceivedAt { get; set; }        
        public int? OutboundEmailID { get; set; }

        public OutboundEmail OutboundEmail { get; set; }
    }
}
