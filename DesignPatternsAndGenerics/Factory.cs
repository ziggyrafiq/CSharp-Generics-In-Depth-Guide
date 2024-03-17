//The File Name is Factory.cs
namespace DesignPatternsAndGenerics;

// Generic Factory Pattern
public class Factory<T> where T : new()
{
    public T CreateInstance()
    {
        return new T();
    }
}
