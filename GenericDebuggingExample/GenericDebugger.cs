//The File Name is GenericDebugger.cs
namespace GenericDebuggingExample;
public class GenericDebugger
{
    // Debugging generic method with type constraints
    public T Find<T>(T[] array, T target) where T : IComparable<T>
    {
        Console.WriteLine($"Debugging: Finding {target} in the array...");

        foreach (var item in array)
        {
            Console.WriteLine($"Debugging: Comparing {item} with {target}...");

            // Debugging logic
            if (item.CompareTo(target) == 0)
            {
                Console.WriteLine($"Debugging: Found {target} in the array!");
                return item;
            }
        }

        Console.WriteLine($"Debugging: {target} not found in the array.");
        return default;
    }
}
