//The File Name is GenericProfiler.cs
namespace GenericProfilingExample;
public class GenericProfiler
{
    public void RunProfiler()
    {
        // Profiling the performance bottleneck
        var bottleneck = new PerformanceBottleneck();

        // Measure the time taken to execute the bottleneck
        var stopwatch = Stopwatch.StartNew();
        bottleneck.SimulateBottleneck();
        stopwatch.Stop();

        Console.WriteLine($"Time taken for the bottleneck: {stopwatch.ElapsedMilliseconds} ms");
    }
}
