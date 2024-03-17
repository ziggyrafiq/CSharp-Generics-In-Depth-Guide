//The File Name is Program.cs
// Covariant scenario
IEnumerable<string> strings = new List<string> { "apple", "banana", "cherry" };
IEnumerable<object> objects = strings; // Covariant assignment

// Iterate over the objects
foreach (var obj in objects)
{
    Console.WriteLine(obj);
}