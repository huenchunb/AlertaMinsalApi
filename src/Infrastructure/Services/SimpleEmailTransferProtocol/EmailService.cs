using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using WebApiAlertaMinsal.Application.Common.Interfaces;

namespace Microsoft.Extensions.DependencyInjection.Services.SimpleEmailTransferProtocol;

public class EmailService(SmtpSettings smtpSettings) : IEmailService
{
    public async Task SendMailAsync(string to, string subject, string htmlContent)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("AlertaMinsal", smtpSettings.SenderEmail));
        message.To.Add(MailboxAddress.Parse(to));
        message.Subject = subject;

        var bodyBuilder = new BodyBuilder { HtmlBody = htmlContent };
        message.Body = bodyBuilder.ToMessageBody();

        using var smtpClient = new SmtpClient();
        try
        {
            SecureSocketOptions secureSocketOptions = smtpSettings.Port switch
            {
                465 => SecureSocketOptions.SslOnConnect,
                587 => SecureSocketOptions.StartTls,
                _ => SecureSocketOptions.Auto
            };
            
            await smtpClient.ConnectAsync(smtpSettings.Host, smtpSettings.Port, secureSocketOptions);
            await smtpClient.AuthenticateAsync(smtpSettings.SenderEmail, smtpSettings.SenderPassword);
            await smtpClient.SendAsync(message);
        }
        finally
        {
            await smtpClient.DisconnectAsync(true);
        }
    }
}
