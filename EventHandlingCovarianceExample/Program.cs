//The File Name is Program.cs
using EventHandlingCovarianceExample;

Zoo myZoo = new Zoo();

// Subscribe to the event using a contravariant handler
myZoo.AnimalAdded += myZoo.HandleAnimalAdded;

// Trigger the event with a specific type of AnimalEventArgs
myZoo.OnAnimalAdded(new AnimalEventArgs("Lion"));
    

