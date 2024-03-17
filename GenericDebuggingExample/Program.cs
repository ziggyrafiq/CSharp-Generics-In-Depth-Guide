//The File Name is Program.cs
// Example usage of debugging generic method
using GenericDebuggingExample;

var debugger = new GenericDebugger();

// Sample array
var array = new[] { 1, 2, 3, 4, 5 };

// Debugging the Find method
var result = debugger.Find(array, 3);

Console.WriteLine($"Result: {result}");