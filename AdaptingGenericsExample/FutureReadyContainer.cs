//The File Name is FutureReadyContainer.cs
namespace AdaptingGenericsExample;
public class FutureReadyContainer<T>
{
    private T value;

    public FutureReadyContainer(T initialValue)
    {
        value = initialValue;
    }

    // Hypothetical future feature: Record Type
    public T Value
    {
        get => value;
        init => value = value is not null ? throw new InvalidOperationException("Value can only be set once.") : value;
    }

    // Hypothetical future feature: Nullable Reference Types
    public void PrintValueLength()
    {
        Console.WriteLine($"Length of the value: {value?.ToString().Length ?? 0}");
    }

    // Additional hypothetical future features can be added here
}
