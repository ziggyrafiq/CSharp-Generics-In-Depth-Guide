//Class File Name is Program.cs
// Example usage of GenericAdvantagesDemo with int as the generic type
using GenericAdvantages;

GenericAdvantagesDemo<int> intDemo = new GenericAdvantagesDemo<int>();
intDemo.DemonstrateAdvantages(42);

// Example usage of GenericAdvantagesDemo with string as the generic type
GenericAdvantagesDemo<string> stringDemo = new GenericAdvantagesDemo<string>();
stringDemo.DemonstrateAdvantages("Hello, Generics!");