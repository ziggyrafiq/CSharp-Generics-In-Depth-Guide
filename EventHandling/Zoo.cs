//The File Name is Zoo.cs
namespace EventHandling;
public class Zoo
{
    public event AnimalEventHandler<AnimalEventArgs> ? AnimalAdded;

    public void AddAnimal(Animal animal)
    {
        // Adding animal logic
        Console.WriteLine($"Adding animal: {animal.Name}");

        // Trigger the event
        AnimalAdded?.Invoke(this, new AnimalEventArgs(animal.Name));
    }

    public void HandleAnimalAdded(object sender, AnimalEventArgs e)
    {
        Console.WriteLine("Animal added to the zoo!");
    }
}
