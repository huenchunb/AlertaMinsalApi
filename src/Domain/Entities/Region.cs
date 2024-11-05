namespace WebApiAlertaMinsal.Domain.Entities;

public class Region(string name)
{
    public int Id { get; set; }
    public string Name { get; set; } = name;
    public virtual ICollection<Comuna> Comunas { get; set; } = [];
}
