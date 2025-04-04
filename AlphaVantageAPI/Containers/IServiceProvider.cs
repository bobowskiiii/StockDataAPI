namespace AlphaVantageAPI.Containers;

public interface IServiceProvider
{
    T? GetService<T>();
}