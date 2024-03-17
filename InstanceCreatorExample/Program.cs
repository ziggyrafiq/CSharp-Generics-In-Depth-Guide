//The File Name is Program.cs

using InstanceCreatorExample;

InstanceCreator creator = new InstanceCreator();

try
{
    // Example usage with a type having a parameterless constructor
    MyClassWithParameterlessConstructor instance1 = creator.CreateInstance<MyClassWithParameterlessConstructor>();
    Console.WriteLine($"Instance 1: {instance1}");

    // Example usage with a type not having a parameterless constructor
    // Uncomment the line below to see the InvalidOperationException
    MyClassWithoutParameterlessConstructor instance2 = creator.CreateInstance(() => new MyClassWithoutParameterlessConstructor(42));

}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
