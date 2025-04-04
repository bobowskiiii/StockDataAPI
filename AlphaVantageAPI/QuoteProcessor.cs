namespace AlphaVantageAPI;

public class QuoteProcessor : IQuoteProcessor
{
    public void ProcessQuote(Data data)
    {
        // Process the quote data here
        // For example, you can print the quote data to the console
        Console.WriteLine($"Symbol: {data.Symbol}");
        Console.WriteLine($"Cena otwarcia: {data.Open}");
        Console.WriteLine($"Najwyższa cena: {data.High}");
        Console.WriteLine($"Najniższa cena: {data.Low}");
        Console.WriteLine($"Cena zamknięcia: {data.Price}");
        Console.WriteLine($"Wolumen: {data.Volume}");
        Console.WriteLine($"Ostatni dzień handlu: {data.LatestTradingDay}");
        Console.WriteLine($"Poprzednie zamknięcie: {data.PreviousClose}");
        Console.WriteLine($"Zmiana: {data.Change}");
        Console.WriteLine($"Procent zmiany: {data.ChangePercent}");
        // Add more processing logic as needed
    }
}