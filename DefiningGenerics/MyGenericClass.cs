// Definition and basic syntax of generics in a Console App Project with using .Net 7
//Class File Name is: MyGenericClass.cs

namespace DefiningGenerics;
public class MyGenericClass<T>
{
    // Generic method showcasing basic syntax
    public T MyMethod(T input)
    {
        // Implementation logic here
        // Example: Print the input value
        Console.WriteLine($"Input value: {input}");

        // Return the input value
        return input;
    }
}
