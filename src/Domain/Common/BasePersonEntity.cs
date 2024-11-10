namespace WebApiAlertaMinsal.Domain.Common;

public abstract class BasePersonEntity : BaseAuditableEntity
{
    public string Rut { get; set; } = string.Empty;
    public string Digito { get; set; } = string.Empty;
    public string RutNormalized { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public string Address { get; set; } = string.Empty;
    public int ComunaId { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public virtual Comuna Comuna { get; set; } = null!;
}
