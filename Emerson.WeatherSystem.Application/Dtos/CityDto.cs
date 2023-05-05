using Emerson.WeatherSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Dtos
{
    public class CityDto
    {
        public string CityName { get; set; } = String.Empty;
        public ICollection<VariableDto>? Variables { get; set; }
    }
}
