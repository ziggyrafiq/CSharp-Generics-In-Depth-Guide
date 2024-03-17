//The File Name is GenericAlgorithm.cs
namespace GenericProfilingBestPractices;
public class GenericAlgorithm<T> where T : IComparable<T>
{
    public T FindMaximum(T[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }

        T maximum = array[0];

        foreach (var item in array)
        {
            if (item.CompareTo(maximum) > 0)
            {
                maximum = item;
            }
        }

        return maximum;
    }
}
