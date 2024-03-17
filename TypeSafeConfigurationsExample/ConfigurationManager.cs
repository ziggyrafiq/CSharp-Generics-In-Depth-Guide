//The File Name is ConfigurationManager.cs
namespace TypeSafeConfigurationsExample;
public class ConfigurationManager<T>
{
    private readonly T configuration;

    public ConfigurationManager(T configuration)
    {
        this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    public T GetConfiguration()
    {
        return configuration;
    }
}
