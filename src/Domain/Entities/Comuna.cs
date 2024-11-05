namespace WebApiAlertaMinsal.Domain.Entities;

public class Comuna(string name, Region region)
{
    public int Id { get; set; }
    public int IdRegion { get; set; }
    public string Name { get; set; } = name;
    public virtual Region RegionNavigation { get; set; } = region;
}
