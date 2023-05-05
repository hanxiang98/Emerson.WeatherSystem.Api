using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Domain;
using GSM.APCM.Apparel.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Emerson.WeatherSystem.Persistence.Repositories
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(EmersonWeatherSystemDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<City>> GetAllCitiesWithVariableAsync()
        {
            return await _context.Cities
                .Include(z => z.Variables)
                .ToListAsync();
        }

        public async Task<HottestCityDto> GetHottestCityAsync()
        {          
            var result = await _context.Variables
               .Where(v => (string.Equals(v.Unit, "°C") && Convert.ToDecimal(v.Value) > 30)
               || (string.Equals(v.Unit, "°F") && (Convert.ToDecimal(v.Value) - 32) * 5 / 9 > 30)
               ) 
               .GroupBy(r => new {
                   r.City.CityName
               })
               .Select(a => new HottestCityDto
               {
                   CityName = a.Key.CityName,
                   NumOfDaysOver30C = a.Count(),
               })
               .AsNoTracking()
               .OrderByDescending(o => o.NumOfDaysOver30C)
               .FirstOrDefaultAsync();

            return result;
        }

        public async Task<MoistestCityDto> GetMoistestCityAsync()
        {
            var result = await _context.Variables
                .Where(v => (string.Equals(v.Name, "Humidity")))
               .GroupBy(r => new {
                   r.City.CityName
               })
               .Select(a => new MoistestCityDto
               {
                   CityName = a.Key.CityName,
                   AverageHumidity = a.Average(v => Convert.ToDecimal(v.Value)),
               })
               .AsNoTracking()
               .OrderByDescending(o => o.AverageHumidity)
               .FirstOrDefaultAsync();

            return result;
        }
    }
}
