//The File Name is Animal.cs
namespace DisplayServiceExample;
public class Animal : IDisplayable
{
    public string Species { get; set; }

    public Animal(string species)
    {
        Species = species;
    }

    public void Display()
    {
        Console.WriteLine($"Animal: {Species}");
    }
}
