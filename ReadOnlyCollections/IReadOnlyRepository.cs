//The File Name is IReadOnlyRepository.cs
// Covariant interface for read-only collections
namespace ReadOnlyCollections;
public interface IReadOnlyRepository<out T>
{
    IEnumerable<T> GetAll();
}
