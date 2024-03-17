//The File Name is EventPublisher.cs
namespace GenericEventsExample;
public class EventPublisher<T>
{
    public event EventHandler<T> GenericEvent;

    public void RaiseEvent(T eventData)
    {
        // Check if there are any subscribers to the event
        if (GenericEvent != null)
        {
            // Invoke the event, passing the sender (this) and the event data
            GenericEvent.Invoke(this, eventData);
        }
    }
}
