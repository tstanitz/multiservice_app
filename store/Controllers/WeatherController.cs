using Microsoft.AspNetCore.Mvc;
using store.Models;

namespace store.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{

    private readonly ILogger<WeatherController> _logger;

    public WeatherController(ILogger<WeatherController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Weather> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Weather
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55)
        })
        .ToArray();
    }
}
