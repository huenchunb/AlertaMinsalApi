namespace WebApiAlertaMinsal.Application.Common.Models;

public class LookupEstablishmentDependenciesDto
{
    public List<LookupDto> EstablishmentComplexity { get; set; } = [];
    public List<LookupDto> EstablishmentLevel { get; set; } = [];
    public List<LookupDto> EstablishmentAtentionType { get; set; } = [];
    public List<LookupDto> EstablishmentType { get; set; } = [];
    public List<LookupDto> EstablishmentUgencyType { get; set; } = [];
}
