//The File Name is DataProcessor.cs
namespace DocumentingGenericsExample;

/// <summary>
/// Provides a set of generic methods for processing data.
/// </summary>
public class DataProcessor
{
    /// <summary>
    /// Processes the input and returns the result.
    /// </summary>
    /// <typeparam name="T">Type of the input.</typeparam>
    /// <param name="input">The input to be processed.</param>
    /// <returns>The processed result.</returns>
    public T Process<T>(T input) => /* Implementation */ input;

    /// <summary>
    /// Filters the elements of a sequence based on a specified predicate.
    /// </summary>
    /// <typeparam name="T">Type of the elements in the sequence.</typeparam>
    /// <param name="sequence">The sequence to filter.</param>
    /// <param name="predicate">A function to test each element for a condition.</param>
    /// <returns>A sequence containing the filtered elements.</returns>
    public IEnumerable<T> Filter<T>(IEnumerable<T> sequence, Func<T, bool> predicate)
    {
        return sequence.Where(predicate);
    }

    /// <summary>
    /// Merges two sequences by applying a specified function to each pair of elements.
    /// </summary>
    /// <typeparam name="TFirst">Type of elements in the first sequence.</typeparam>
    /// <typeparam name="TSecond">Type of elements in the second sequence.</typeparam>
    /// <typeparam name="TResult">Type of elements in the result sequence.</typeparam>
    /// <param name="first">The first sequence to merge.</param>
    /// <param name="second">The second sequence to merge.</param>
    /// <param name="mergeFunction">A function to apply to each pair of elements.</param>
    /// <returns>A sequence containing the merged elements.</returns>
    public IEnumerable<TResult> Merge<TFirst, TSecond, TResult>(
        IEnumerable<TFirst> first,
        IEnumerable<TSecond> second,
        Func<TFirst, TSecond, TResult> mergeFunction)
    {
        return first.Zip(second, mergeFunction);
    }
}
