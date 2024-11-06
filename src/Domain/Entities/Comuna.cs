namespace WebApiAlertaMinsal.Domain.Entities;

public class Comuna(string name)
{
    public int Id { get; set; }
    public int IdRegion { get; set; }
    public string Name { get; set; } = name;
    public virtual Region Region { get; set; } = null!;
}
