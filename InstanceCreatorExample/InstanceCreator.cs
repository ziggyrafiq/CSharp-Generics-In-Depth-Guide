//The File Name is InstanceCreator.cs
namespace InstanceCreatorExample;
public class InstanceCreator
{
    public T CreateInstance<T>() where T : new()
    {
        if (typeof(T).GetConstructor(Type.EmptyTypes) != null)
        {
            return new T();
        }
        else
        {
            throw new InvalidOperationException("Type does not have a parameterless constructor.");
        }
    }

    public T CreateInstance<T>(Func<T> factoryMethod)
    {
        return factoryMethod();
    }




}
