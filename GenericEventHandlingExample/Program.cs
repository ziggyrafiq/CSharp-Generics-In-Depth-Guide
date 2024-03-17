//The File Name is Program.cs
// Create instances of EventPublisher and EventSubscriber
using GenericEventHandlingExample;

EventPublisher<int> intEventPublisher = new EventPublisher<int>();
EventSubscriber eventSubscriber = new EventSubscriber();

// Subscribe the event subscriber to the generic event
eventSubscriber.Subscribe(intEventPublisher);

// Raise the event with some data
int eventData = 42;
intEventPublisher.RaiseEvent(eventData);