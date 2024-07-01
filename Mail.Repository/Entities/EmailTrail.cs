using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Repository.Entities
{
    public class EmailTrail
    {
        public int EmailTrailID { get; set; }
        public int OutboundEmailID { get; set; }
        public string EmailType { get; set; }
        public int EmailID { get; set; }
        public DateTime EventTime { get; set; }
    }
}
