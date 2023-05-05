using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Features.Queries;
using Emerson.WeatherSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Contracts.Persistence
{
    public interface IVariableRepository : IGenericRepository<Variable>
    {
        Task<IEnumerable<Variable>> GetVariables(GetVariablesQuery query);
    }
}
