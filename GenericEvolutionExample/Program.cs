//The File Name is Program.cs
// .NET Framework 2.0: Basic generics
using GenericEvolutionExample;

GenericClass<int> intGenericClass = new GenericClass<int>(42);
int intValue = intGenericClass.GetValue();
Console.WriteLine($"Value from .NET Framework 2.0: {intValue}");

// .NET Framework 4.0: Covariant interface
ICovariantDataProvider<string> stringDataProvider = new CovariantDataProvider();
string stringValue = stringDataProvider.GetData();
Console.WriteLine($"Data from .NET Framework 4.0 (Covariant): {stringValue}");

// .NET 8: Covariant return types
IDataProvider<Animal> animalDataProvider = new AnimalDataProvider();
Animal animal = animalDataProvider.GetData();
Console.WriteLine($"Data from .NET 8 (Covariant Return Types): {animal.Name}");
