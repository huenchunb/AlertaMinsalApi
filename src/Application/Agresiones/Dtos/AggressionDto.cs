namespace WebApiAlertaMinsal.Application.Agresiones.Dtos;

public class AggressionDto
{
    public int AgresionId { get; set; }
    public string EstadoAgresion { get; set; } = string.Empty;
    public DateTime FechaAgresion { get; set; }
    public string? TipoAgresion { get; set; } = string.Empty;
    public List<string> CategoriasAgresion { get; set; } = [];
    public List<AgresorDto> Agresores { get; set; } = [];
    public List<TestigoDto> Testigos { get; set; } = [];
}

public class AgresorDto
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

public class TestigoDto
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
