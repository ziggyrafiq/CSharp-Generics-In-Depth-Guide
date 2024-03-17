//The File Name is EventPublisher.cs
namespace GenericEventHandlingExample;
public class EventPublisher<T>
{
    public event EventHandler<EventArgs> GenericEvent;

    public void RaiseEvent(T eventData)
    {
        if (GenericEvent != null)
        {
            GenericEvent.Invoke(this, new EventArgs<T>(eventData));
        }
    }
}