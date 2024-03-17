//The File Name is ServiceContainer.cs
namespace GenericDependencyInjectionExample;

// Generic Dependency Injection
public class ServiceContainer
{
    private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

    public void RegisterService<TService, TImplementation>(ServiceLifetime lifetime = ServiceLifetime.Transient)
        where TImplementation : TService
    {
        if (lifetime == ServiceLifetime.Singleton && services.ContainsKey(typeof(TService)))
        {
            throw new InvalidOperationException($"Singleton service {typeof(TService).Name} is already registered.");
        }

        switch (lifetime)
        {
            case ServiceLifetime.Singleton:
                services[typeof(TService)] = Activator.CreateInstance<TImplementation>();
                break;
            case ServiceLifetime.Transient:
                services[typeof(TService)] = typeof(TImplementation);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(lifetime), lifetime, null);
        }
    }

    public TService GetService<TService>()
    {
        var serviceType = services[typeof(TService)];

        if (serviceType is Type)
        {
            return (TService)Activator.CreateInstance((Type)serviceType);
        }

        return (TService)serviceType;
    }
}
