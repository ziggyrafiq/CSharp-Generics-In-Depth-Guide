//The File Name is UnitOfWork.cs
namespace GenericRepositoryEnterpriseExample;
public class UnitOfWork : IDisposable
{
    private readonly DbContext dbContext;

    public UnitOfWork(DbContext dbContext)
    {
        this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public IRepository<Customer> Customers => new GenericRepository<Customer>(dbContext);

    public void SaveChanges()
    {
        dbContext.SaveChanges();
    }

    public void Dispose()
    {
        dbContext.Dispose();
    }
}
