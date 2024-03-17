//The File Name is GenericService.cs
namespace GenericDependencyInjectionExample;

// Implementation of a generic service
public class GenericService<T> : IService
{
    public void Execute()
    {
        Console.WriteLine($"Executing {typeof(T).Name} service.");
    }
}
