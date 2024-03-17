//The File Name is IContravariant.cs
namespace ContravariantInterface;
public interface IContravariant<in T>
{
    void SetItem(T item);
}
