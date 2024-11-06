namespace WebApiAlertaMinsal.Domain.Entities;

public class Establecimiento(
    string name,
    int tipoEstablecimientoId,
    int nivelEstablecimientoId,
    string address,
    string streetNumber,
    int phoneNumber,
    bool urgency,
    int tipoUrgenciaEstablecimientoId,
    double longitude,
    double latitude,
    int complejidadEstablecimientoId,
    int tipoAtencionEstablecimientoId,
    int comunaId) : BaseAuditableEntity
{
    public string Name { get; set; } = name;
    public int TipoEstablecimientoId { get; set; } = tipoEstablecimientoId;
    public int NivelEstablecimientoId { get; set; } = nivelEstablecimientoId;
    public string Address { get; set; } = address;
    public string StreetNumber { get; set; } = streetNumber;
    public int PhoneNumber { get; set; } = phoneNumber;
    public bool Urgency { get; set; } = urgency;
    public int TipoUrgenciaEstablecimientoId { get; set; } = tipoUrgenciaEstablecimientoId;
    public double Longitude { get; set; } = longitude;
    public double Latitude { get; set; } = latitude;
    public int ComplejidadEstablecimientoId { get; set; } = complejidadEstablecimientoId;
    public int TipoAtencionEstablecimientoId { get; set; } = tipoAtencionEstablecimientoId;
    public int ComunaId { get; set; } = comunaId;
    public virtual TipoEstablecimiento TipoEstablecimiento { get; set; } = null!;
    public virtual NivelEstablecimiento NivelEstablecimiento { get; set; } = null!;
    public virtual TipoUrgenciaEstablecimiento TipoUrgenciaEstablecimiento { get; set; } = null!;
    public virtual ComplejidadEstablecimiento ComplejidadEstablecimiento { get; set; } = null!;
    public virtual TipoAtencionEstablecimiento TipoAtencionEstablecimiento { get; set; } = null!;
    public virtual Comuna Comuna { get; set; } = null!;
}
