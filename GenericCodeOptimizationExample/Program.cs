//The File Name is Program.cs
// Example usage of optimized generic algorithm
using GenericCodeOptimizationExample;

var optimizer = new GenericOptimizer();

// Sample array
var intArray = new[] { 5, 9, 3, 7, 1 };

// Find the maximum value in the array
var maxInt = optimizer.FindMaximum(intArray);
Console.WriteLine($"Maximum value in the array: {maxInt}");

// Another example with strings
var stringArray = new[] { "apple", "banana", "orange", "grape" };
var maxString = optimizer.FindMaximum(stringArray);
Console.WriteLine($"Maximum value in the array: {maxString}");