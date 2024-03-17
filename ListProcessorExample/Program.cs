//The File Name is Program.cs
// Example usage of ListProcessor with a custom Transformer
using ListProcessorExample;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

// Define a transformer to square each number
Transformer<int, int> squareTransformer = ListProcessor.Square;

// Process the list using the ListProcessor
List<int> squaredNumbers = ListProcessor.ProcessList(numbers, squareTransformer);

// Display the results
Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));
Console.WriteLine("Squared Numbers: " + string.Join(", ", squaredNumbers));