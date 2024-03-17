//The File Name is Program.cs
// Example usage of adapting existing generic code to utilize new language features
using AdaptingGenericsExample;

var container = new FutureReadyContainer<string>(initialValue: "Hello, Future!");

// Hypothetical future feature: Record Type
Console.WriteLine($"Initial Value: {container.Value}");

// Try to set the value again (using init property)
// This will throw an InvalidOperationException due to the init property
// Uncomment the line below to see the exception
// container.Value = "New Value";

// Hypothetical future feature: Nullable Reference Types
container.PrintValueLength();