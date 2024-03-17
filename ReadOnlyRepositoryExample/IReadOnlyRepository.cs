//The File Name is IReadOnlyRepository.cs
// Interface design for read-only operations with covariance
namespace ReadOnlyRepositoryExample;
public interface IReadOnlyRepository<out T>
{
    IEnumerable<T> GetAll();
}
