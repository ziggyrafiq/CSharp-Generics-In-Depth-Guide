//The File Name is Program.cs
// Create an instance of EventPublisher with int as the event data type
using GenericEventsExample;

EventPublisher<int> intEventPublisher = new EventPublisher<int>();

// Subscribe to the generic event with an event handler
intEventPublisher.GenericEvent += EventHandlerFunctions.IntEventHandler;

// Raise the event with some data
int eventData = 42;
intEventPublisher.RaiseEvent(eventData);