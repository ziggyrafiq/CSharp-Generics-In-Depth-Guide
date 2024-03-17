//The File Name is EventArgs.cs
namespace GenericEventHandlingExample;
public class EventArgs<T> : EventArgs
{
    public T Data { get; }

    public EventArgs(T data)
    {
        Data = data;
    }
}