using System.Reflection;
using Mapster;
using MapsterCodeGenPOC.Models;

namespace MapsterCodeGenPOC.Configurations
{
    public class MapperConfiguration : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("[name]Dto", MapType.Map)
                .ApplyDefaultRules()
                .ForType<State>();

            config.AdaptTo("[name]Dto", MapType.Map)
                .ApplyDefaultRules()
                .ForType<WeatherForecast>(builder =>
                {
                    builder.Map(poco => poco.TemperatureC, "Celcius");
                    builder.Map(poco => poco.TemperatureF, "Fahrenheit");
                });

            config.GenerateMapper("[name]Mapper")
                .ForType<WeatherForecast>()                
                .ForType<State>();
        }
    }

    public static class MapperConfigurationExtension
    {
        public static AdaptAttributeBuilder ApplyDefaultRules(this AdaptAttributeBuilder builder)
        {
            return builder.ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "MapsterCodeGenPOC.Models");
        } 
    }
}