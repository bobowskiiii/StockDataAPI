using Flurl;
using Flurl.Http;
using AlphaVantageAPI.Models;

namespace AlphaVantageAPI;

public class AlphaVantageService : IAlphaVantageService
{
    private readonly string _url = "https://www.alphavantage.co/query";
    private readonly string _apiKey = "demo";

    public async Task<Quote> GetQuoteAsync(string symbol)
    {
        var response = await _url
            .SetQueryParams(new
            {
                function = "GLOBAL_QUOTE",
                symbol = symbol,
                apikey = _apiKey
            })
            .GetJsonAsync<Dictionary<string, Dictionary<string, string>>>();

        var quoteData = response["Global Quote"];
        var data = new Data
        {
            Symbol = quoteData["01. symbol"],
            Open = quoteData["02. open"],
            High = quoteData["03. high"],
            Low = quoteData["04. low"],
            Price = quoteData["05. price"],
            Volume = quoteData["06. volume"],
            LatestTradingDay = DateTime.Parse(quoteData["07. latest trading day"]),
            PreviousClose = quoteData["08. previous close"],
            Change = quoteData["09. change"],
            ChangePercent = quoteData["10. change percent"]
        };

        return new Quote { Data = data };
    }
}