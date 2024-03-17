//The File Name is CovariantImplementation.cs
// Covariant implementation
namespace CovariantInterface;
public class CovariantImplementation<T> : ICovariant<T>
{
    private T item;

    public CovariantImplementation(T item)
    {
        this.item = item;
    }

    public T GetItem()
    {
        return item;
    }
}

