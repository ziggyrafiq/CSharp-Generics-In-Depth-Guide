//Class Name is GenericConstructsDemo.cs
// Generic classes, methods, and interfaces in action
namespace GenericConstructs;
public class GenericConstructsDemo<T>
{
    // Generic method showcasing versatility
    public void MyGenericMethod<U>(U input)
    {
        // Implementation logic here
        // Example: Print the input value of the generic method
        Console.WriteLine($"Generic method input: {input}");

        // Additional implementation logic can be added based on specific requirements
    }

    // Generic interface promoting code reusability
    public interface IMyGenericInterface<U>
    {
        // Interface members here
        // Example: Interface method using the generic type U
        U GetDefaultValue();
    }
}