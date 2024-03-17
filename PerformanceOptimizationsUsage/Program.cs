//The File Name is Program.cs
using PerformanceOptimizationsUsage;
// Create an instance of a class implementing IDataProcessor
DataProcessor dataProcessor = new DataProcessor();

// Call the generic method with ValueTask<T>
int result = await ExtraTasks.ProcessAsyncData(dataProcessor);

// Output the result
Console.WriteLine($"Processed Result: {result}");
