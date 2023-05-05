using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Dtos
{
    public class HottestCityDto : CityDto
    {
        public int NumOfDaysOver30C { get; set; }

    }
}
