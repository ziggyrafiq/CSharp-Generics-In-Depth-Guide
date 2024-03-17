//The File Name is Route.cs
namespace GenericsInWebFrameworksExample;
public class Route<TController>
{
    private readonly Dictionary<string, Action> routeTable = new Dictionary<string, Action>();

    public void AddRoute(string path, Action action)
    {
        routeTable[path] = action;
    }

    public void RouteRequest(string path)
    {
        if (routeTable.TryGetValue(path, out var action))
        {
            action.Invoke();
        }
        else
        {
            Console.WriteLine($"No route found for path: {path}");
        }
    }
}
