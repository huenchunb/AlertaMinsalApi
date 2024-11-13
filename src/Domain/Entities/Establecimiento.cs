namespace WebApiAlertaMinsal.Domain.Entities;

public class Establecimiento : BaseAuditableEntity
{
    public string Name { get; set; } = string.Empty;
    public int TipoEstablecimientoId { get; set; }
    public int NivelEstablecimientoId { get; set; }
    public string Address { get; set; } = string.Empty;
    public string StreetNumber { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public bool Urgency { get; set; }
    public int TipoUrgenciaEstablecimientoId { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public int ComplejidadEstablecimientoId { get; set; }
    public int TipoAtencionEstablecimientoId { get; set; }
    public int ComunaId { get; set; }
    public virtual TipoEstablecimiento TipoEstablecimiento { get; set; } = null!;
    public virtual NivelEstablecimiento NivelEstablecimiento { get; set; } = null!;
    public virtual TipoUrgenciaEstablecimiento TipoUrgenciaEstablecimiento { get; set; } = null!;
    public virtual ComplejidadEstablecimiento ComplejidadEstablecimiento { get; set; } = null!;
    public virtual TipoAtencionEstablecimiento TipoAtencionEstablecimiento { get; set; } = null!;
    public virtual Comuna Comuna { get; set; } = null!;
    public virtual ICollection<Empleado> Empleados { get; set; } = [];
}
