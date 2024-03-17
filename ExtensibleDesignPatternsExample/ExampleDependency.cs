//The File Name is ExampleDependency.cs
namespace ExtensibleDesignPatternsExample;

/// <summary>
/// Example dependency class.
/// </summary>
public class ExampleDependency
{
    /// <summary>
    /// Represents the dependency.
    /// </summary>
    public string DependencyValue { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExampleDependency"/> class.
    /// </summary>
    /// <param name="dependencyValue">The value of the dependency.</param>
    public ExampleDependency(string dependencyValue)
    {
        DependencyValue = dependencyValue;
    }

    /// <inheritdoc/>
    public override string ToString() => DependencyValue;
}
