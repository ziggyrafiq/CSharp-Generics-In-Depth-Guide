//The File Name is GenericClass.cs
namespace GenericEvolutionExample;

// .NET Framework 2.0: Basic generics
public class GenericClass<T>
{
    private T value;

    public GenericClass(T value)
    {
        this.value = value;
    }

    public T GetValue()
    {
        return value;
    }
}
