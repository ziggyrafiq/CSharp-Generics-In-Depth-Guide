//The File Name is Program.cs
// Create an array of integers
int[] data = { 1, 2, 3, 4, 5 };

// Call the generic method with Span<T>
ProcessData(data.AsSpan());

// Output the modified array
Console.WriteLine("Modified Array:");
foreach (var item in data)
{
    Console.WriteLine(item);
}
