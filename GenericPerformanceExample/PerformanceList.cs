//The File Name is PerformanceList.cs
namespace GenericPerformanceExample;
public class PerformanceList<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        // Avoiding boxing and unboxing
        if (typeof(T).IsValueType)
        {
            items.Add(item);
        }
        else
        {
            throw new ArgumentException("Reference types are not supported for performance reasons.");
        }
    }

    public void PrintItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
