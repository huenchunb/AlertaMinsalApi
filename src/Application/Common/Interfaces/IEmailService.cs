namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface IEmailService
{
    Task SendMailAsync(string to, string subject, string htmlContent);
}
