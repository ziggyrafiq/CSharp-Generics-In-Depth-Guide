//The File Name is GenericRepository.cs
namespace GenericRepositoryEnterpriseExample;

public class GenericRepository<T> : IRepository<T> where T : class
{
    private readonly DbContext dbContext;

    public GenericRepository(DbContext dbContext)
    {
        this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public T GetById(int id)
    {
        return dbContext.Set<T>().Find(id);
    }

    public void Add(T entity)
    {
        dbContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        dbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            dbContext.Set<T>().Remove(entity);
        }
    }
}
