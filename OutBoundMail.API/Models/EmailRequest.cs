namespace OutBoundMail.API.Models
{
    public class EmailRequest
    {
        public string TemplateId { get; set; }
        public string Recipient { get; set; }
    }
}
