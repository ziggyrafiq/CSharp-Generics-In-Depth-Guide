//The File Name is ContravariantImplementation.cs
// Contravariant implementation
namespace ContravariantInterface;
public class ContravariantImplementation<T> : IContravariant<T>
{
    public void SetItem(T item)
    {
        // Implementation logic
        Console.WriteLine($"Setting item: {item}");
    }
}
