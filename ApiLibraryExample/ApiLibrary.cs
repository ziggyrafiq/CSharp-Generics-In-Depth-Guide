//The File Name is ApiLibrary.cs
namespace ApiLibraryExample;
public class ApiLibrary
{
    // Covariant API method
    public IEnumerable<object> GetItems()
    {
        // Logic for fetching items
        return new List<object> { "item1", "item2", "item3" };
    }

    // Contravariant API method
    public void SetItem(object item)
    {
        // Logic for setting an item
        Console.WriteLine($"Setting item: {item}");
    }
}
