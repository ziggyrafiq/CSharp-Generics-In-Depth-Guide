//The File Name is Logger.cs
namespace GenericLoggerExample;
// Generic Logger Component
public class Logger<T> where T : ILoggable
{
    public void Log(T loggableObject)
    {
        // Logging logic
        Console.WriteLine($"Logging: {loggableObject.GetMessage()}");
    }
}
