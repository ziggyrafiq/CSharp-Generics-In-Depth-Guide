//The File Name is IDataProvider.cs
namespace GenericsInDotNet8;
// New feature: Covariant return types
public interface IDataProvider<out T>
{
    T GetData();
}
