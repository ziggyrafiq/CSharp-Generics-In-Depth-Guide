//The File Name is ArraySearch.cs
namespace ArraySearchExample;
public class ArraySearch
{
    public T? FindFirst<T>(T[] array, T target)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        foreach (var item in array)
        {
            if (EqualityComparer<T>.Default.Equals(item, target))
            {
                return item;
            }
        }

        return default;
    }
}