using Mapster;
using MapsterCodeGenPOC.Models;

namespace MapsterCodeGenPOC.Configurations
{
    public class MapperConfiguration : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("[name]Dto", MapType.Map)
                .ForType<WeatherForecast>(builder =>
                {
                    builder.Map(poco => poco.TemperatureC, "Celcius");
                    builder.Map(poco => poco.TemperatureF, "Fahrenheit");
                });

            config.GenerateMapper("[name]Mapper")
                .ForType<WeatherForecast>();
        }
    }
}