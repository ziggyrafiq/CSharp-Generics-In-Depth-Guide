//The File Name is Program.cs
using GenericRepositoryPatternExample;
// Using the Generic Repository Pattern
IRepository<User> userRepository = new UserRepository();

// Add a user
User newUser = new User { Id = 1, Name = "John Doe" };
userRepository.Add(newUser);

// Get user by Id
User retrievedUser = userRepository.GetById(1);

Console.WriteLine("Using the Generic Repository Pattern:");
Console.WriteLine($"User Id: {retrievedUser.Id}, User Name: {retrievedUser.Name}");