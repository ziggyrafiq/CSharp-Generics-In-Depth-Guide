//The File Name is Program.cs
// Covariance with read-only collections
IEnumerable<object> objects = new List<string> { "apple", "banana", "cherry" }; // Covariant assignment

// Try to add an integer to the list
// This will not compile with IEnumerable<object> since it's read-only
// If you need to perform mutable operations, consider using a List<object> instead
// objects.Add(42); 

// If you need to perform mutable operations, use List<object>
List<object> mutableObjects = new List<object>(objects);

// Try to add an integer to the list
try
{
    mutableObjects.Add(42); // Runtime error: InvalidCastException
}
catch (InvalidCastException ex)
{
    Console.WriteLine($"Runtime error: {ex.Message}");
}

// Iterate over the objects and print each element
Console.WriteLine("\nList contents:");
foreach (var obj in mutableObjects)
{
    Console.WriteLine(obj);
}