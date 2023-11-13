using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    
 
    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<string> Get([FromServices]IDistributedCache cache)
{
   var weather = await cache.GetStringAsync("weather");

   if (weather == null)
   {
     _logger.LogInformation("NotCahced");
      var rng = new Random();
      var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
         Date = DateTime.Now.AddDays(index),
         TemperatureC = rng.Next(-20, 55),
         Summary = Summaries[rng.Next(Summaries.Length)]
      })
      .ToArray();

      weather = JsonSerializer.Serialize(forecasts);

      await cache.SetStringAsync("weather", weather, new DistributedCacheEntryOptions
      {
         AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5)
      });
   }
    _logger.LogInformation(weather);
   return weather;
}
}
