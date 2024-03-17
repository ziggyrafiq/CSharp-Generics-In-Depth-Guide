//The File Name is SimpleGeneric.cs
namespace SimpleGenericExample;
public class SimpleGeneric
{
    public T FindFirst<T>(T[] array, T target)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        foreach (var item in array)
        {
            if (Equals(item, target))
            {
                return item;
            }
        }

        return default;
    }
}
