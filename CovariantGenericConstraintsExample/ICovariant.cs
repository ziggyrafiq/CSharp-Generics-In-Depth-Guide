//The File Name is ICovariant.cs
namespace CovariantGenericConstraintsExample;
public interface ICovariant<out T> where T : IComparable
{
    T GetItem();
}
