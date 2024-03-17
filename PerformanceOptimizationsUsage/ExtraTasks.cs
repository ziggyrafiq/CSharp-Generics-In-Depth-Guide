//The File Name is ExtraTasks.cs
namespace PerformanceOptimizationsUsage;
public static class ExtraTasks
{
    // Efficient memory usage with ValueTask<T>
    public static async ValueTask<int> ProcessAsyncData<T>(T data) where T : IDataProcessor
    {
        // Asynchronous processing logic
        int result = await data.ProcessAsync();

        // For the sake of the example, doubling the result
        return result * 2;
    }

}
