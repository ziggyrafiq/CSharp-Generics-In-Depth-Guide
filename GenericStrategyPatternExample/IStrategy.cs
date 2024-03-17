//The File Name is IStrategy.cs
namespace GenericStrategyPatternExample;
public interface IStrategy<T>
{
    void Execute(T context);
}
