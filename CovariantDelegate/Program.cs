//The File Name is Program.cs
// Covariant delegate usage
using CovariantDelegate;

Func<object> covariantFunc = () => "Hello, Covariance!";
CovariantDelegate<object> covariantDelegate = new CovariantDelegate<object>(covariantFunc); // Covariant assignment

// Invoke the covariant delegate
object result = covariantDelegate();
Console.WriteLine(result);