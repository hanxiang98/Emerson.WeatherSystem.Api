using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Features.Queries;
using Emerson.WeatherSystem.Application.IntergrationTests;
using Emerson.WeatherSystem.Application.IntergrationTests.TestData;
using Emerson.WeatherSystem.Domain;
using Emerson.WeatherSystem.Persistence.Repositories;
using GSM.APCM.Apparel.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.UnitTest.Features.Queries
{
    public class VariableRepositoryTests
    {
        private readonly IVariableRepository _IVariableRepository;

        public VariableRepositoryTests()
        {
            var dbOptions = new DbContextOptionsBuilder<EmersonWeatherSystemDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var _EmersonWeatherSystemDbContext = new EmersonWeatherSystemDbContext(dbOptions);


            var variables = TestVariables.GetTestVariables();
            _EmersonWeatherSystemDbContext.AddRange(variables);
            _EmersonWeatherSystemDbContext.SaveChanges();

            _IVariableRepository = new VariableRepository(_EmersonWeatherSystemDbContext);

        }

        [Fact]
        public async Task GetVariablesAsyncTests()
        {
            GetVariablesQuery query = new GetVariablesQuery();
            query.CityName = "Singapore";
            query.VariableName = "Humidity";
            query.StartTimeStamp = DateTimeOffset.Parse("2023-01-02T00:00:00.0000000+00:00");
            query.EndTimeStamp = DateTimeOffset.Parse("2023-01-08T00:00:00.0000000+00:00");

            var variables = await _IVariableRepository.GetVariablesAsync(query);

            variables.ShouldBeOfType<List<Variable>>();
            variables.Count().ShouldBe(7);

        }
    }
}
