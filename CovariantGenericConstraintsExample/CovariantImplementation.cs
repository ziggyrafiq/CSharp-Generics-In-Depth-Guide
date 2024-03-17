//The File Name is CovariantImplementation.cs
namespace CovariantGenericConstraintsExample;
public class CovariantImplementation<T> : ICovariant<T> where T : IComparable
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
