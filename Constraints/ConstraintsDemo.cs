//File Name is ConstraintsDemo.cs
namespace Constraints;
public class ConstraintsDemo<T> where T : class, new()
{
    // Generic method with constraints ensuring type safety
    public void MyConstrainedMethod(T input)
    {
        // Implementation logic here
        // Example: Check if the input is not null and create a new instance if it is null
        if (input == null)
        {
            input = new T();
            Console.WriteLine("Created a new instance of type T.");
        }

        // Additional implementation logic can be added based on specific requirements
    }
}
