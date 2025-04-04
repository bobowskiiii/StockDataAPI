
namespace AlphaVantageAPI;

public interface IAlphaVantageService
{
    Task<Quote> GetQuoteAsync(string symbol);
}