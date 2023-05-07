using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Features.Queries;
using Emerson.WeatherSystem.Domain;
using GSM.APCM.Apparel.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Persistence.Repositories
{
    public class VariableRepository : GenericRepository<Variable>, IVariableRepository
    {
        public VariableRepository(EmersonWeatherSystemDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Variable>> GetVariablesAsync(GetVariablesQuery query)
        {
            var variables =  await _context.Variables
                .Include(z => z.City)
                .Where(w => string.Equals(w.Name, query.VariableName) 
                    && string.Equals(w.City.CityName, query.CityName)
                    && query.StartTimeStamp <= w.TimeStamp && w.TimeStamp <= query.EndTimeStamp)
                .AsNoTracking()
                .ToListAsync();

            return variables;

        }
    }
}
