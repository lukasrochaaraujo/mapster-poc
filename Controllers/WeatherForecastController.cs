using System;
using System.Collections.Generic;
using System.Linq;
using MapsterCodeGenPOC.Dtos;
using MapsterCodeGenPOC.Models;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MapsterCodeGenPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                State = new State() { Name = "Brazil" }
            })
            .ToArray();
        }

        [HttpGet("dto")]
        public IEnumerable<WeatherForecastDto> GetAsDto()
        {
            var rng = new Random();
            var weatherForecastArray = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                State = new State() { Name = "Brazil" }
            })
            .ToArray();

            return _mapper.Map<IEnumerable<WeatherForecastDto>>(weatherForecastArray);
        }
    }
}
