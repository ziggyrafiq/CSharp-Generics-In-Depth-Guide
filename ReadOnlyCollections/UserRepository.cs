//The File Name is UserRepository.cs
// Example usage
namespace ReadOnlyCollections;
public class UserRepository : IReadOnlyRepository<User>
{
    public IEnumerable<User> GetAll()
    {
        // Logic to fetch users (placeholder implementation returning an empty list)
        return new List<User>
        {
            new User { UserName = "JohnDoe" },
            new User { UserName = "JaneDoe" },
            new User { UserName = "HarryPotter" }
        };
    }
}
