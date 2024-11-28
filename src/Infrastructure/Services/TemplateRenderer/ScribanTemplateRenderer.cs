using Scriban;
using WebApiAlertaMinsal.Application.Common.Interfaces;

namespace WebApiAlertaMinsal.Infrastructure.Services.TemplateRenderer;

public class ScribanTemplateRenderer : ITemplateRenderer
{
    private readonly string _templatesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");

    public async Task<string> RenderTemplateAsync(string templateName, object model)
    {
        var templatePath = Path.Combine(_templatesDirectory, templateName);
        if (!File.Exists(templatePath))
        {
            throw new FileNotFoundException($"Template '{templateName}' not found in '{_templatesDirectory}'.");
        }

        var templateContent = await File.ReadAllTextAsync(templatePath);
        var template = Template.Parse(templateContent);

        if (template.HasErrors)
        {
            throw new InvalidOperationException(
                $"Errors in template '{templateName}': {string.Join(", ", template.Messages)}");
        }

        return await template.RenderAsync(model, member => member.Name);
    }
}
