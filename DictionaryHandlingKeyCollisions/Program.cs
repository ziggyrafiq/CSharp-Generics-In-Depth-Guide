//The File Name is Program.cs
// Handling key collisions in Dictionary
Dictionary<string, int> ages = new Dictionary<string, int>();
ages.TryAdd("Alice", 25);
ages.TryAdd("Bob", 30);
ages.TryAdd("Alice", 28); // Ignored due to existing key

// Displaying the Dictionary after handling key collisions
Console.WriteLine("Dictionary after handling key collisions:");
foreach (var kvp in ages)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// Handling exceptions
try
{
    ages.Add("Alice", 28); // Throws an exception
}
catch (ArgumentException ex)
{
    Console.WriteLine($"\nException: {ex.Message}");
}