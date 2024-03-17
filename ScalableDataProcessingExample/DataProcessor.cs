//The File Name is DataProcessor.cs
namespace ScalableDataProcessingExample;
public static class DataProcessor<T>
{
    public static void ProcessData(IEnumerable<T> data)
    {
        foreach (var item in data)
        {
            // Placeholder for data processing logic
            Console.WriteLine($"Processing data item: {item}");
        }
    }

    public static IEnumerable<string> GenerateLargeDataSet()
    {
        // Generate a large dataset (for demonstration purposes)
        var dataSet = new List<string>();
        for (int i = 1; i <= 1_000_000; i++)
        {
            dataSet.Add($"DataItem-{i}");
        }
        return dataSet;
    }
}
