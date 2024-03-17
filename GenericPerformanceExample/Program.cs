//The File Name is Program.cs
// Example usage of performance-optimized generic class
using GenericPerformanceExample;

var intList = new PerformanceList<int>();
var stopwatch = new Stopwatch();

// Measure the performance of adding 1 million integers to the list
stopwatch.Start();
for (int i = 0; i < 1_000_000; i++)
{
    intList.Add(i);
}
stopwatch.Stop();

Console.WriteLine($"Time taken to add 1 million integers: {stopwatch.ElapsedMilliseconds} ms");

// Print a few items as a sample
intList.PrintItems();