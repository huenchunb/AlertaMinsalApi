namespace WebApiAlertaMinsal.Domain.Events;

public class CreateAggresionEvent(Agresion item): BaseEvent
{
    public Agresion Item { get; } = item;   
}
