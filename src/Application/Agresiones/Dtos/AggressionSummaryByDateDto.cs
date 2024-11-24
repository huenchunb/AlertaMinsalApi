namespace WebApiAlertaMinsal.Application.Agresiones.Dtos;

public class AggressionSummaryByDateDto
{
    public string Date { get; set; } = String.Empty;
    public int PhysicalAggressions { get; set; }
    public int VerbalAggressions { get; set; }
}
