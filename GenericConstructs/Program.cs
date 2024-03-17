//Class File Name is Program.cs
// Example usage of GenericConstructsDemo with int as the generic type
using GenericConstructs;

GenericConstructsDemo<int> intDemo = new GenericConstructsDemo<int>();
intDemo.MyGenericMethod("Hello, Generics!"); // Using the generic method with string as input

// Example usage of GenericConstructsDemo with string as the generic type
GenericConstructsDemo<string> stringDemo = new GenericConstructsDemo<string>();
stringDemo.MyGenericMethod(42); // Using the generic method with int as input

// Example usage of the generic interface
var interfaceImplementation = new InterfaceImplementation();
var defaultValue = interfaceImplementation.GetDefaultValue();
Console.WriteLine($"Interface Default Value: {defaultValue}");