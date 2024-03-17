//The File Name is Singleton.cs
namespace GenericsInCreationalPatterns;

// Generic Singleton Pattern
public static class Singleton<T> where T : new()
{
    private static T instance;

    public static T Instance => instance ??= new T();
}
