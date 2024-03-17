//The File Name is Context.cs
namespace GenericStrategyPatternExample;
public class Context<T>
{
    private IStrategy<T> strategy;

    public void SetStrategy(IStrategy<T> newStrategy)
    {
        strategy = newStrategy;
    }

    public void ExecuteStrategy(T context)
    {
        strategy.Execute(context);
    }
}
