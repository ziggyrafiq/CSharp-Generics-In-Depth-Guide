//The File Name is Person.cs
namespace DisplayServiceExample;
public class Person : IDisplayable
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Person: {Name}");
    }
}
