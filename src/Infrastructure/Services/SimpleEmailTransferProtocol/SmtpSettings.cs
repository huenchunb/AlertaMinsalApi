namespace Microsoft.Extensions.DependencyInjection.Services.SimpleEmailTransferProtocol;

public class SmtpSettings
{
    public string Host { get; set; } = string.Empty;
    public int Port { get; set; }
    public string SenderEmail { get; set; } = string.Empty;
    public string SenderPassword { get; set; } = string.Empty;
    public bool UseSsl { get; set; }
}
