//The File Name is Program.cs
using ClearDocumentationExample;

MaximumFinder finder = new MaximumFinder();

// Example usage with integers
List<int> intList = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
int maxInt = finder.FindMaximum(intList);
Console.WriteLine($"Maximum integer: {maxInt}");

// Example usage with strings
List<string> stringList = new List<string> { "apple", "banana", "orange" };
string maxString = finder.FindMaximum(stringList);
Console.WriteLine($"Maximum string: {maxString}");
