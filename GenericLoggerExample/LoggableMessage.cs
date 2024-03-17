//The File Name is LoggableMessage.cs
namespace GenericLoggerExample;
// Example class implementing ILoggable
public class LoggableMessage : ILoggable
{
    private readonly string message;

    public LoggableMessage(string message)
    {
        this.message = message;
    }

    public string GetMessage()
    {
        return message;
    }
}
