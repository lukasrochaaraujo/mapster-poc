using MapsterCodeGenPOC.Models;

namespace MapsterCodeGenPOC.Dtos
{
    public static partial class WeatherForecastMapper
    {
        public static WeatherForecastDto AdaptToDto(this WeatherForecast p1)
        {
            return p1 == null ? null : new WeatherForecastDto()
            {
                Date = p1.Date,
                Celcius = p1.TemperatureC,
                Fahrenheit = p1.TemperatureF,
                Summary = p1.Summary
            };
        }
    }
}