//The File Name is Program.cs
// TrimExcess example
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Displaying the original list
Console.WriteLine("Original List:");
Console.WriteLine(string.Join(", ", numbers));

// Removing an element from the list
numbers.Remove(2);

// Displaying the list after removal
Console.WriteLine("\nList after Removal:");
Console.WriteLine(string.Join(", ", numbers));

// Applying TrimExcess to reduce memory overhead
numbers.TrimExcess();

// Displaying the list after applying TrimExcess
Console.WriteLine("\nList after Applying TrimExcess:");
Console.WriteLine(string.Join(", ", numbers));