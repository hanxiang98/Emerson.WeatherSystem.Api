using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Dtos
{
    public class VariableDto
    {
        public string Name { get; set; } = String.Empty;
        public string Unit { get; set; } = String.Empty;
        public decimal Value { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public string CityName { get; set; } = String.Empty;
    }
}
