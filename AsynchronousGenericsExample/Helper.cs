//The File Name is Helper.cs
namespace AsynchronousGenericsExample;
public static class Helper
{
    public static void DisplayResult<T>(T result)
    {
        Console.WriteLine($"Result: {result}");
        Console.WriteLine();
    }
}
