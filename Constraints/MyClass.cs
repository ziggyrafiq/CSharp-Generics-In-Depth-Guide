//Class File Name is MyClass.cs
namespace Constraints;
public class MyClass
{
    // Class definition
    public int Id { get; set; }
    public string Name { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}
