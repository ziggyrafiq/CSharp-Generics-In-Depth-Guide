//The File Name is PerformanceBottleneck.cs
namespace GenericProfilingExample;
public class PerformanceBottleneck
{
    // Intentional performance bottleneck for demonstration
    public void SimulateBottleneck()
    {
        for (int i = 0; i < 1_000_000; i++)
        {
            var result = Math.Pow(i, 2); // Simulating a heavy computation
        }
    }
}
