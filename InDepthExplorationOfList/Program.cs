//The file name is Program.cs
// Creating a List of integers
List<int> numbers = new List<int>();

// Adding elements to the List
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);

// Accessing elements
Console.WriteLine("Original List:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// Modifying elements in the List
numbers[1] = 25;

// Adding more elements
numbers.Add(40);
numbers.Add(50);

// Accessing modified and new elements
Console.WriteLine("\nModified List with Additional Elements:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// Removing an element
numbers.Remove(30);

// Accessing elements after removal
Console.WriteLine("\nList after Removing an Element:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// Checking if the List contains a specific value
bool containsValue = numbers.Contains(25);
Console.WriteLine($"\nList contains value 25: {containsValue}");

// Finding the index of a specific value
int indexOfValue = numbers.IndexOf(40);
Console.WriteLine($"Index of value 40: {indexOfValue}");