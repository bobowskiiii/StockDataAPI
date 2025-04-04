namespace AlphaVantageAPI.Containers;
public class ServiceProviderr : IServiceProvider
{
    private readonly Dictionary<Type, Type> _services = new();

    public void AddTransient<TService, TImplementation>()
    {
        _services[typeof(TService)] = typeof(TImplementation);
    }
    
    public T? GetService<T>()
    {
        var implementationType = _services[typeof(T)];
        return (T)Activator.CreateInstance(implementationType);
    }
}