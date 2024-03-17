//The File Name is Program.cs
// Example usage of the UserRepository
using ReadOnlyCollections;

UserRepository userRepository = new UserRepository();
IEnumerable<User> users = userRepository.GetAll();

// Display user information (for demonstration purposes)
foreach (var user in users)
{
    Console.WriteLine($"User Name: {user.UserName}");
    
}