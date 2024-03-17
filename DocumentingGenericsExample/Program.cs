//The File Name is Program.cs

/// <summary>
/// Entry point for the application and the Main method of the application.
/// </summary>
using DocumentingGenericsExample;

// Example usage of documenting generics for clarity
var processor = new DataProcessor();

// Process method
var processedValue = processor.Process("Hello, Generics!");
Console.WriteLine($"Processed Value: {processedValue}");

// Filter method
var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var filteredNumbers = processor.Filter(numbers, x => x % 2 == 0);
Console.WriteLine($"Filtered Numbers: {string.Join(", ", filteredNumbers)}");

// Merge method
var names = new List<string> { "John", "Jane", "Tom" };
var mergedPairs = processor.Merge(numbers, names, (num, name) => $"{num}-{name}");
Console.WriteLine($"Merged Pairs: {string.Join(", ", mergedPairs)}");