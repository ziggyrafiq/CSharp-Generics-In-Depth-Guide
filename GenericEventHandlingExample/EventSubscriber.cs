//The File Name is EventSubscriber.cs
namespace GenericEventHandlingExample;
public class EventSubscriber
{
    public void Subscribe<T>(EventPublisher<T> publisher)
    {
        // Cast EventArgsBase to EventArgs<T> within the lambda expression
        publisher.GenericEvent += (sender, e) => HandleGenericEvent<T>(sender, (EventArgs<T>)e);
    }

    private void HandleGenericEvent<T>(object sender, EventArgs<T> e)
    {
        // Event handling logic
        Console.WriteLine($"Received generic event with data: {e.Data}");
    }
}