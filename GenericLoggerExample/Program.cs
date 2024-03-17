//The File Name is Program.cs
// Example usage of the generic logger
using GenericLoggerExample;

var logger = new Logger<LoggableMessage>();
var loggableObject = new LoggableMessage("This is a loggable message.");

logger.Log(loggableObject);