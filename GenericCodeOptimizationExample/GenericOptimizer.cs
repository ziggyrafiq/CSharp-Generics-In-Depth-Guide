//The File Name is GenericOptimizer.cs
namespace GenericCodeOptimizationExample;
public class GenericOptimizer
{
    // Optimizing generic algorithms with constraints
    public T FindMaximum<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array must not be null or empty.");
        }

        T maximum = array[0];

        foreach (var item in array)
        {
            // Use CompareTo for comparison instead of operators for better compatibility
            if (item.CompareTo(maximum) > 0)
            {
                maximum = item;
            }
        }

        return maximum;
    }
}
