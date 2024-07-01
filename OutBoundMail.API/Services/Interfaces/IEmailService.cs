namespace OutBoundMail.API.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string templateId, string recipient);
    }
}
