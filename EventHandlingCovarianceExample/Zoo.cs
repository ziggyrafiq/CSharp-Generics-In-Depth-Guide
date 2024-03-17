//The File Name is Zoo.cs
namespace EventHandlingCovarianceExample;

public class Zoo
{
    public event AnimalEventHandler<AnimalEventArgs> ? AnimalAdded;

    public virtual void OnAnimalAdded(AnimalEventArgs e)
    {
        AnimalAdded?.Invoke(this, e);
    }

    public void HandleAnimalAdded(object sender, AnimalEventArgs e)
    {
        Console.WriteLine($"New animal added to the zoo: {e.AnimalName}");
    }
}
