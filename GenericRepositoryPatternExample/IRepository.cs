//The File Name is IRepository.cs
namespace GenericRepositoryPatternExample;

// Generic Repository Pattern
public interface IRepository<T>
{
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}
