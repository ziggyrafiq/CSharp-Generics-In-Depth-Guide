//The File Name is EventHandlerFunctions.cs
namespace GenericEventsExample;
public static class EventHandlerFunctions
{
    // Event handler for the generic event
    public static void IntEventHandler(object sender, int eventData)
    {
        Console.WriteLine($"Received event with data: {eventData}");
    }
}
