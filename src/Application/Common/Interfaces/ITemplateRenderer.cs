namespace WebApiAlertaMinsal.Application.Common.Interfaces;

public interface ITemplateRenderer
{
    Task<string> RenderTemplateAsync(string templateName, object model);
}
