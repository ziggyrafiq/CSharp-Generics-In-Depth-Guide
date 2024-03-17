//The File Name is MaximumFinder.cs
namespace ClearDocumentationExample;

/// <summary>
/// A utility class for finding the maximum element in a collection.
/// </summary>
public class MaximumFinder
{
    /// <summary>
    /// Finds the maximum element in the given collection.
    /// </summary>
    /// <typeparam name="T">The type of elements in the collection.</typeparam>
    /// <param name="collection">The collection to search for the maximum element.</param>
    /// <returns>The maximum element in the collection.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the input collection is null.</exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the elements in the collection do not implement the IComparable<T> interface.
    /// </exception>
    public T FindMaximum<T>(IEnumerable<T> collection) where T : IComparable<T>
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection), "The input collection cannot be null.");
        }

        T max = default;

        foreach (var item in collection)
        {
            if (max == null || item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        if (max == null)
        {
            throw new InvalidOperationException("The collection is empty; cannot find the maximum element.");
        }

        return max;
    }
}
