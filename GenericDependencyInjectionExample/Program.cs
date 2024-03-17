//The File Name is Program.cs
using GenericDependencyInjectionExample;
// Example usage of generic dependency injection
var container = new ServiceContainer();

// Register a singleton service
container.RegisterService<IService, GenericService<string>>(ServiceLifetime.Singleton);

// Register a transient service
container.RegisterService<IService, GenericService<int>>(ServiceLifetime.Transient);

// Get and execute services
var singletonService = container.GetService<IService>();
singletonService.Execute();

var transientService = container.GetService<IService>();
transientService.Execute();