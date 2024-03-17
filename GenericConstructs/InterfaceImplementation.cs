//Class Name is InterfaceImplementation.cs
namespace GenericConstructs;

// Example implementation of the generic interface
public class InterfaceImplementation : GenericConstructsDemo<int>.IMyGenericInterface<string>
{
    public string GetDefaultValue()
    {
        // Implementation logic here
        return "Default String Value";
    }
}
