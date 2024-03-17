//The File Name is FutureReadyService.cs
namespace ExtensibleDesignPatternsExample;

/// <summary>
/// Design pattern: Dependency injection for future extensibility.
/// </summary>
/// <typeparam name="TDependency">Type of the dependency to be injected.</typeparam>
public class FutureReadyService<TDependency>
{
    private readonly TDependency dependency;

    /// <summary>
    /// Initializes a new instance of the <see cref="FutureReadyService{TDependency}"/> class.
    /// </summary>
    /// <param name="dependency">The dependency to be injected.</param>
    public FutureReadyService(TDependency dependency)
    {
        this.dependency = dependency;
    }

    /// <summary>
    /// Executes a service operation using the injected dependency.
    /// </summary>
    public void ExecuteServiceOperation()
    {
        // Simulated service operation using the injected dependency
        Console.WriteLine($"Executing service operation with dependency: {dependency.ToString()}");
    }
}
