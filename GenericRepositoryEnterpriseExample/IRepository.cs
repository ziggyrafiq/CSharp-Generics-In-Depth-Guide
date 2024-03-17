//The File Name is IRepository.cs
namespace GenericRepositoryEnterpriseExample;
public interface IRepository<T>
{
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}
