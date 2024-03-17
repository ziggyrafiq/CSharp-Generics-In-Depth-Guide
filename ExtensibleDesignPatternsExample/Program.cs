//The File Name is Program.cs
// Example usage of dependency injection for future extensibility
using ExtensibleDesignPatternsExample;

var exampleDependency = new ExampleDependency("Future Dependency");
var futureReadyService = new FutureReadyService<ExampleDependency>(exampleDependency);

// Execute service operation
futureReadyService.ExecuteServiceOperation();
    