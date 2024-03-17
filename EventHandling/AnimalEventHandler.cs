namespace EventHandling;
// Covariant delegate for event handling
public delegate void AnimalEventHandler<in T>(object sender, T e);

