using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Dtos
{
    public class MoistestCityDto : CityDto
    {
        public decimal AverageHumidity { get; set; }
    }
}
