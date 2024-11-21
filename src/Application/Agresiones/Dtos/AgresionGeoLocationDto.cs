namespace WebApiAlertaMinsal.Application.Agresiones.Dtos;

public class AgresionGeoLocationDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public int AgresionConArmaFuego { get; set; }
    public int AgresionesConArmaBlanca { get; set; }
    public int AgresionesConObjetoContundente { get; set; }
    public int AgresionesSexualesTocaciones { get; set; }
    public int AgresionesEmpujonesCombos { get; set; }
    public int AgresionesOtro { get; set; }
    public int AgresionesInfraestructura { get; set; }
    public int AgresionesSexualesLenguaje { get; set; }
    public int AgresionesAmenazas { get; set; }
    public int AgresionesInsultos { get; set; }
    public int AgresionesBurlas { get; set; }
    public int AgresionesRedesSociales { get; set; }
    public int AgresionesOtroVerbal { get; set; }
    public int TotalAgresionesFisicas { get; set; }
    public int TotalAgresionesVerbales { get; set; }
}
