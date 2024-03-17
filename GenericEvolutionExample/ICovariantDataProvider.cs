//The File Name is ICovariantDataProvider.cs

namespace GenericEvolutionExample;

// .NET Framework 4.0: Covariant interface
public interface ICovariantDataProvider<out T>
{
    T GetData();
}
