using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Contracts.Persistence
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<IEnumerable<City>> GetAllCitiesWithVariableAsync();
        Task<HottestCityDto> GetHottestCityAsync();
        Task<MoistestCityDto> GetMoistestCityAsync();
    }
}
