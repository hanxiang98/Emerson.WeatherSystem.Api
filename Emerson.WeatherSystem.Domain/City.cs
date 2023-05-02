using Emerson.WeatherSystem.Domain.Common;

namespace Emerson.WeatherSystem.Domain
{
    public class City : BaseDomainEntity
    {
        public string CityName { get; set; } = String.Empty;
    }
}