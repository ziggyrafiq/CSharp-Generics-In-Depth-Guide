//The File Name is Program.cs
// Covariant example
using CovarianceContravarianceExample;

IEnumerable<Derived> derivedItems = new List<Derived>
            {
                new Derived { Value = "Derived Item 1" },
                new Derived { Value = "Derived Item 2" }
            };

IEnumerable<Base> baseItems = derivedItems;

Console.WriteLine("Covariant Example:");
foreach (var item in baseItems)
{
    Console.WriteLine(item.Value);
}

// Contravariant example
Action<Base> baseAction = (baseObj) => Console.WriteLine($"Base Action: {baseObj.Value}");
Action<Derived> derivedAction = baseAction; // Contravariant assignment

Console.WriteLine("\nContravariant Example:");
derivedAction(new Derived { Value = "Contravariant Item" });
        }
