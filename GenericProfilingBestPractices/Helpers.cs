//The File Name is Helper.cs
namespace GenericProfilingBestPractices;
public static class Helpers
{
    public static int[] GenerateLargeArray()
    {
        const int arraySize = 1_000_000;
        var random = new Random();
        var largeArray = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            largeArray[i] = random.Next(1, 1000);
        }

        return largeArray;
    }

    public static void ProfileFindMaximum(GenericAlgorithm<int> algorithm, int[] array)
    {
        // Profiling the FindMaximum method
        var stopwatch = Stopwatch.StartNew();
        var result = algorithm.FindMaximum(array);
        stopwatch.Stop();

        Console.WriteLine($"Maximum value found: {result}");
        Console.WriteLine($"Time taken for FindMaximum: {stopwatch.ElapsedMilliseconds} ms");
    }

}
