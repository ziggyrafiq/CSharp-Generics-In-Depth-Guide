//The File Name is ConcreteStrategyB.cs
namespace GenericStrategyPatternExample;

// Concrete strategy implementation 2
public class ConcreteStrategyB : IStrategy<int>
{
    public void Execute(int context)
    {
        Console.WriteLine($"Executing ConcreteStrategyB with context: {context}");
    }
}
