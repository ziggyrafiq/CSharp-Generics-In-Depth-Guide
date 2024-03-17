//The File Name is ICovariant.cs
namespace CovariantInterface;
public interface ICovariant<out T>
{
    T GetItem();
}
