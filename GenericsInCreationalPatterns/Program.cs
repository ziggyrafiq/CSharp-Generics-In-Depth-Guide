//The File Name is Program.cs
// Using the Generic Singleton Pattern
using GenericsInCreationalPatterns;

Singleton<ExampleClass> singleton = Singleton<ExampleClass>.Instance;

Console.WriteLine("Using the Generic Singleton Pattern:");
Console.WriteLine($"Type of the singleton instance: {singleton.GetType().Name}");