using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Repository.Entities
{
    public class EmailFailure
    {
        public int ID { get; set; }
        public int OutboundEmailID { get; set; }
        public string FailureReason { get; set; }
        public DateTime OccurredAt { get; set; }

        public OutboundEmail OutboundEmail { get; set; }
    }
}
