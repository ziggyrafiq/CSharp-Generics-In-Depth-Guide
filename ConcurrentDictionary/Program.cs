//The File Name is Program.cs
// Using ConcurrentDictionary
using System.Collections.Concurrent;

ConcurrentDictionary<string, int> concurrentAges = new ConcurrentDictionary<string, int>();

// Adding key-value pairs using TryAdd
concurrentAges.TryAdd("Alice", 25);

// Displaying the contents of ConcurrentDictionary
Console.WriteLine("ConcurrentDictionary Contents:");
foreach (var kvp in concurrentAges)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}