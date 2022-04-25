using app.Models;

namespace app.Services;
public interface IStoreService
{
    Task<List<WeatherForecast>> GetWeatherAsync();
}