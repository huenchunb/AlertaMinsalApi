namespace WebApiAlertaMinsal.Domain.Entities;

public class Testigo : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Rut { get; set; } = string.Empty;
    public string Digito { get; set; } = string.Empty;
    public string RutNormalized { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public virtual ICollection<AgresionTestigo> AgresionTestigos { get; set; } = [];
}
