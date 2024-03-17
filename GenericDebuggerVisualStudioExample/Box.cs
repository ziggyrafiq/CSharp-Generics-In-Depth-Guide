//The File Name is Box.cs
namespace GenericDebuggerVisualStudioExample;
public class Box<T>
{
    public T Content { get; set; }

    // Debugging constructor
    public Box(T content)
    {
        Content = content;
    }
}
