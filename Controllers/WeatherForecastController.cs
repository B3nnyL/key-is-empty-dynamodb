using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dynamodb_csharp_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IAmazonDynamoDB _dynamodb;
        private readonly DynamoDBContext _context;
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAmazonDynamoDB dynamoDB)
        {
            _logger = logger;
            _dynamodb = dynamoDB;
            _context = new DynamoDBContext(_dynamodb);
        }


        [HttpGet]
        public async Task<WeatherForecast> GetWeatherUsingHashKey(int id)
        {
            var mockWeather = new WeatherForecast
            {
                Id = null,
                Date = DateTime.Now,
                TemperatureC = 30,
                Summary = "fake summer"
            };
            return await _context.LoadAsync<WeatherForecast>(mockWeather);
        }


        [HttpPost]
        public async Task SaveWeatherUsingHashKey()
        {
            var mockWeather = new WeatherForecast {
                Id = 1,
                Date = DateTime.Now,
                TemperatureC = 30,
                Summary = "fake summer"
            };
            await _context.SaveAsync<WeatherForecast>(mockWeather);
        }
    }
}
