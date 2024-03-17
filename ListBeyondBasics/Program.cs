//The File Name is Program.cs
// Sorting a List of integers
List<int> numbers = new List<int> { 5, 2, 8, 1, 7 };
numbers.Sort();

// Displaying the sorted numbers
Console.WriteLine("Sorted Numbers:");
foreach (var number in numbers)
{
    Console.Write($"{number} ");
}

// Filtering even numbers using LINQ
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

// Displaying the filtered even numbers
Console.WriteLine("\n\nEven Numbers:");
foreach (var number in evenNumbers)
{
    Console.Write($"{number} ");
}

// Sorting the filtered even numbers in descending order
evenNumbers.Sort((a, b) => b.CompareTo(a));

// Displaying the sorted even numbers in descending order
Console.WriteLine("\n\nSorted Even Numbers (Descending):");
foreach (var number in evenNumbers)
{
    Console.Write($"{number} ");
}

// Checking if a specific number is in the list
int checkNumber = 8;
bool containsNumber = evenNumbers.Contains(checkNumber);

// Displaying the result of the check
Console.WriteLine($"\n\nIs {checkNumber} in the list of even numbers? {containsNumber}");
    