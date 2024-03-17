//The File Name is Extended.cs
using GenericsInWebFrameworksExample.Controllers;

namespace GenericsInWebFrameworksExample;

public static class Extended
{
    public static void SimulateRequest(Route<HomeController> routeHandler, string path)
    {
        Console.WriteLine($"Handling request for path: {path}");
        routeHandler.RouteRequest(path);
        Console.WriteLine();
    }
}
