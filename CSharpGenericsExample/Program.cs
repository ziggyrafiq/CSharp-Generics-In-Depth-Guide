//The File Name is Program.cs
// Covariant scenario for read-only operations
IEnumerable<string> strings = new List<string> { "apple", "banana", "cherry" };
IEnumerable<object> objects = strings; // Covariant assignment

// Iterate over the objects
Console.WriteLine("Covariant scenario:");
foreach (var obj in objects)
{
    Console.WriteLine(obj);
}

// Contravariant scenario for write-only operations
Action<object> printObject = obj => Console.WriteLine(obj);
Action<string> printString = printObject; // Contravariant assignment

// Invoke the contravariant delegate
Console.WriteLine("\nContravariant scenario:");
printString("Hello, Contravariance!");