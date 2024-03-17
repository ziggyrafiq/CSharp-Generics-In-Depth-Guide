//The File Name is Program.cs
// Example usage
using CovariantGenericConstraintsExample;

ICovariant<string> stringCovariant = new CovariantImplementation<string>("Hello, Covariance!");
Console.WriteLine(stringCovariant.GetItem());

ICovariant<int> intCovariant = new CovariantImplementation<int>(42);
Console.WriteLine(intCovariant.GetItem());