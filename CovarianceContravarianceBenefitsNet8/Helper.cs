
//The File Name is Helper.cs
namespace CovarianceContravarianceBenefitsNet8;
public static class Helper
{
    // Covariant usage in a method
    public static IEnumerable<Base> ProcessData<T>(IEnumerable<T> items) where T : Base
    {
        // Implementation
        foreach (var item in items)
        {
            Console.WriteLine(item.Value);
        }

        // For the sake of the example, returning a new list with the same items
        return new List<Base>(items);
    }

    // Contravariant example
    public static void ContravariantExample()
    {
        // Create a contravariant delegate
        Action<Base> baseAction = (baseObj) => Console.WriteLine($"Base Action: {baseObj.Value}");
        Action<Derived> derivedAction = baseAction; // Contravariant assignment

        Console.WriteLine("\nContravariant Example:");
        derivedAction(new Derived { Value = "Contravariant Item" });
    }

    // Covariant example
    public static void CovariantExample()
    {
        // Create a list of derived items
        List<Derived> derivedItems = new List<Derived>
        {
            new Derived { Value = "Derived Item 1" },
            new Derived { Value = "Derived Item 2" }
        };

        // Call the covariant method with the list of derived items
        IEnumerable<Base> baseItems = ProcessData(derivedItems);

        Console.WriteLine("Covariant Example:");
        foreach (var item in baseItems)
        {
            Console.WriteLine(item.Value);
        }
    }

}
