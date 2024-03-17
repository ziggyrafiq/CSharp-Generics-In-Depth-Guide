//The File Name is UserRepository.cs
namespace GenericRepositoryPatternExample;
public class UserRepository : IRepository<User>
{
    private User storedUser;

    public User GetById(int id)
    {
        return storedUser;
    }

    public void Add(User entity)
    {
        storedUser = entity;
    }

    public void Update(User entity)
    {
        // Implementation for updating user
    }

    public void Delete(int id)
    {
        storedUser = null;
    }
}
