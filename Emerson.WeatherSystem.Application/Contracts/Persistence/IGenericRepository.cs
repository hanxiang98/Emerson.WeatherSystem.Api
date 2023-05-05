using Emerson.WeatherSystem.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseDomainEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
