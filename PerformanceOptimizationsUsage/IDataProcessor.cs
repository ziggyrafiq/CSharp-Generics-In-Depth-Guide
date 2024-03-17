//The File Name is IDataProcessor.cs
namespace PerformanceOptimizationsUsage;
public interface IDataProcessor
{
    Task<int> ProcessAsync();
}
