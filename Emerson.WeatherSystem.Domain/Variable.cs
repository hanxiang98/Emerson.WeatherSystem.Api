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
        public Decimal Value { get; set; }
        public DateTime TimeStamp { get; set; }
        public int CityId { get; set; }
    }
}
