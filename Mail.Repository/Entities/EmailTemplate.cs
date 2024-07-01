using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail.Repository.Entities
{
    public class EmailTemplate
    {
        public int TemplateID { get; set; }
        public string TemplateName { get; set; }
        public string SubjectTemplate { get; set; }
        public string BodyTemplate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
