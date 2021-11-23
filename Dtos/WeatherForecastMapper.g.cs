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
                Summary = p1.Summary,
                State = p1.State == null ? null : new StateDto() {Name = p1.State.Name}
            };
        }
    }
}