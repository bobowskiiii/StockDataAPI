
using AlphaVantageAPI;
using AlphaVantageAPI.Containers;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceProviderr();
serviceProvider.AddTransient<IAlphaVantageService, AlphaVantageService>();
serviceProvider.AddTransient<IQuoteProcessor, QuoteProcessor>();

var alphaVantageService = serviceProvider.GetService<IAlphaVantageService>();
var quoteProcessor = serviceProvider.GetService<IQuoteProcessor>();


var quote = await alphaVantageService.GetQuoteAsync("APLL");
if (quote?.Data != null)
{
    quoteProcessor.ProcessQuote(quote.Data);
}
else
{
    Console.WriteLine("Brak danych do przetworzenia.");
}



