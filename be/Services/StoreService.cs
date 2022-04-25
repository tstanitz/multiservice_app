using app.Models;
using System.Text.Json;
using System.IO;

namespace app.Services;

public class StoreService : IStoreService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public StoreService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<WeatherForecast>> GetWeatherAsync()
    {
        var httpClient = _httpClientFactory.CreateClient();

        // var httpResponseMessage = await httpClient.GetAsync("http://store/weather");
        var httpResponseMessage = await httpClient.GetAsync("http://localhost:5009/weather");
        if (httpResponseMessage.IsSuccessStatusCode)
        {
            using var contentStream =
                await httpResponseMessage.Content.ReadAsStreamAsync();

            return await JsonSerializer.DeserializeAsync<List<WeatherForecast>>(contentStream);
        }
        return null;
    }
}
