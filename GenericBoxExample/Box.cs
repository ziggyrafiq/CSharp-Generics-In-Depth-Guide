//The File Name is Box.cs
namespace GenericBoxExample;
public class Box<T>
{
    public T Content { get; set; }

    public Box(T content)
    {
        Content = content;
    }

    public void DisplayContent()
    {
        Console.WriteLine($"Box Content: {Content}");
    }
}
