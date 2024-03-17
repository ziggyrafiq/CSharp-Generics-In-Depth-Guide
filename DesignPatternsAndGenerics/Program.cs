//The File Name is Program.cs
// Using the Generic Factory Pattern
using DesignPatternsAndGenerics;

Factory<DummyClass> factory = new Factory<DummyClass>();
DummyClass instance = factory.CreateInstance();

Console.WriteLine("Using the Generic Factory Pattern:");
Console.WriteLine($"Type of the created instance: {instance.GetType().Name}");