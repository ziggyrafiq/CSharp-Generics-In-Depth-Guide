//The File Name is StringDataProvider.cs
namespace GenericsInDotNet8;
public class StringDataProvider : IDataProvider<string>
{
    public string GetData()
    {
        return "Hello, .NET 8 Generics!";
    }
}

