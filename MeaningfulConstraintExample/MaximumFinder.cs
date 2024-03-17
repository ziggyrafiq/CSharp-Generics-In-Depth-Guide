//The File Name is Program.cs
namespace MeaningfulConstraintExample;
public class MaximumFinder
{
    public T FindMaximum<T>(IEnumerable<T> collection) where T : IComparable<T>
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        T max = default;

        foreach (var item in collection)
        {
            if (max == null || item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        return max;
    }
}
