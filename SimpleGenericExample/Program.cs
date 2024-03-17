//The File Name is Program.cs
using SimpleGenericExample;

SimpleGeneric example = new SimpleGeneric();

// Example usage with integers
int[] intArray = { 1, 2, 3, 4, 5 };
int targetInt = 3;
int resultInt = example.FindFirst(intArray, targetInt);
Console.WriteLine($"First occurrence of {targetInt}: {resultInt}");

// Example usage with strings
string[] stringArray = { "apple", "banana", "orange" };
string targetString = "banana";
string resultString = example.FindFirst(stringArray, targetString);
Console.WriteLine($"First occurrence of '{targetString}': {resultString}");
