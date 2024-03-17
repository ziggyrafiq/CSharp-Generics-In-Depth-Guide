//The File Name is DataProcessor.cs
namespace PerformanceOptimizationsUsage;
public class DataProcessor : IDataProcessor
{
    public Task<int> ProcessAsync()
    {
        // Simulate asynchronous processing
        return Task.FromResult(42);
    }
}
