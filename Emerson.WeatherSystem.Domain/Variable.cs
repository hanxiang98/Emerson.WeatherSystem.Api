using Emerson.WeatherSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Domain
{
    public class Variable : BaseDomainEntity
    {
        public string Name { get; set; } = String.Empty;
        public string Unit { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;
        public DateTimeOffset TimeStamp { get; set; }
        public int CityId { get; set; }
        public City City { get; set; } = new City();
    }
}
