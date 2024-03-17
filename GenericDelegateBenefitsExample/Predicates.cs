//The File Name is Predicates.cs
namespace GenericDelegateBenefitsExample;

// Define a generic delegate for a predicate
public delegate bool Predicate<T>(T item);
public static class Predicates
{
    // Predicate to check if a number is even
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
