//The File Name is Program.cs
// Create an instance of the covariant implementation
using CovariantInterface;

CovariantImplementation<string> stringImplementation = new CovariantImplementation<string>("Hello, Covariance!");

// Use the covariant interface
ICovariant<object> objectCovariant = stringImplementation; // Covariant assignment

// Get and print the item using the covariant interface
object result = objectCovariant.GetItem();
Console.WriteLine(result);