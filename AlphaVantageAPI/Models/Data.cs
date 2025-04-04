using System.Text.Json.Serialization;

namespace AlphaVantageAPI.Models;

public class Data
{
    [JsonPropertyName("01. symbol")] public string Symbol;
    [JsonPropertyName("02. open")] public string Open;
    [JsonPropertyName("03. high")] public string High;
    [JsonPropertyName("04. low")] public string Low;
    [JsonPropertyName("05. price")] public string Price;
    [JsonPropertyName("06. volume")] public string Volume;
    [JsonPropertyName("07. latest trading day")] public DateTime LatestTradingDay;
    [JsonPropertyName("08. previous close")] public string PreviousClose;
    [JsonPropertyName("09. change")] public string Change;
    [JsonPropertyName("09. change percent")] public string ChangePercent;
}