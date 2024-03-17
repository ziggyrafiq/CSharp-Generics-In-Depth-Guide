//The File Name is ConcreteStrategyA.cs
namespace GenericStrategyPatternExample;
// Concrete strategy implementation 1
public class ConcreteStrategyA : IStrategy<string>
{
    public void Execute(string context)
    {
        Console.WriteLine($"Executing ConcreteStrategyA with context: {context}");
    }
}
