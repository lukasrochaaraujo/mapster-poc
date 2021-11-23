using System;
using MapsterCodeGenPOC.Dtos;

namespace MapsterCodeGenPOC.Dtos
{
    public partial record WeatherForecastDto
    {
        public DateTime Date { get; set; }
        public int Celcius { get; set; }
        public int Fahrenheit { get; set; }
        public string Summary { get; set; }
        public StateDto State { get; set; }
    }
}