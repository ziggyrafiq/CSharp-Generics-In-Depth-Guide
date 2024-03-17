//The File Name is Helper.cs
namespace TypeSafeConfigurationsExample;
public static class Helper
{
    public static void DisplayConfiguration(AppConfiguration config)
    {
        Console.WriteLine($"Configuration Details:");
        Console.WriteLine($"App Name: {config.AppName}");
        Console.WriteLine($"Max Connections: {config.MaxConnections}");
        // Display additional configuration properties...
        Console.WriteLine();
    }
}
