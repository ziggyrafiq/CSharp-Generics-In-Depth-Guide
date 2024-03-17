//The File Name is HomeController.cs
namespace GenericsInWebFrameworksExample.Controllers;
public class HomeController
{
    public static void Index()
    {
        Console.WriteLine("Executing Index action");
    }

    public static void About()
    {
        Console.WriteLine("Executing About action");
    }

    public static void Contact()
    {
        Console.WriteLine("Executing Contact action");
    }
}