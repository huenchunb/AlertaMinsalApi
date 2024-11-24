namespace WebApiAlertaMinsal.Application.Agresiones.Dtos;

public class AggressionDto
{
    public int AgresionId { get; set; }
    public string EstadoAgresion { get; set; } = string.Empty;
    public DateTime FechaAgresion { get; set; }
    public string FechaAgresionNormalizada { get; set; } = string.Empty;
    public string? TipoAgresion { get; set; } = string.Empty;
    public string? CreadoPor { get; set; } = string.Empty;
    public string? ActualizadoPor { get; set; } = string.Empty;
    public DateTimeOffset FechaCreacion { get; set; }
    public string FechaCreacionNormalizada { get; set; }= string.Empty;
    public DateTimeOffset FechaActualizacion { get; set; }
    public string FechaActualizacionNormalizada { get; set; }= string.Empty;
    public AgresionEmpleadoDto Empleado { get; set; } = null!;
    public AgresionEstablecimientoDto Establecimiento { get; set; } = null!;
    public List<string> CategoriasAgresion { get; set; } = [];
    public List<AgresionAgresorDto> Agresores { get; set; } = [];
    public List<AgresionTestigoDto> Testigos { get; set; } = [];
}

public class AgresionAgresorDto
{
    public int Id { get; set; }
    public string? Comuna { get; set; }
    public string? Digito { get; set; }
    public string? Direccion { get; set; }
    public string? FullName { get; set; }
    public string? LastName { get; set; }
    public string? Name { get; set; }
    public string? Rut { get; set; }
    public string? RutNormalized { get; set; }
}

public class AgresionTestigoDto
{
    public string Digito { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public int Id { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public string Rut { get; set; } = string.Empty;
    public string RutNormalized { get; set; } = string.Empty;
}

public class AgresionEmpleadoDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string RutNormalized { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int PhoneNumber { get; set; }
    public string Comuna { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
}

public class AgresionEstablecimientoDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Comuna { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
}
