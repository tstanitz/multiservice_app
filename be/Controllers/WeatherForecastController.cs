using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Services;

namespace api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStoreService _storeService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStoreService storeService)
        {
            _logger = logger;
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<List<WeatherForecast>> GetAsync()
        {
            var weather = await _storeService.GetWeatherAsync();
            return null;
        }
    }
}
