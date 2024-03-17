//The File Name is ReadOnlyRepository.cs
namespace ReadOnlyRepositoryExample;
public class ReadOnlyRepository<T> : IReadOnlyRepository<T>
{
    private readonly List<T> data;

    public ReadOnlyRepository(IEnumerable<T> initialData)
    {
        if (initialData == null)
        {
            throw new ArgumentNullException(nameof(initialData));
        }

        data = new List<T>(initialData);
    }

    public IEnumerable<T> GetAll()
    {
        return data;
    }
}
