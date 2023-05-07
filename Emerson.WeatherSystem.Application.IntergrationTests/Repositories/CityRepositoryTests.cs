using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.IntergrationTests;
using Emerson.WeatherSystem.Application.IntergrationTests.TestData;
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
    public class CityRepositoryTests
    {
        private readonly ICityRepository _ICityRepository;

        public CityRepositoryTests()
        {
            var dbOptions = new DbContextOptionsBuilder<EmersonWeatherSystemDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var _EmersonWeatherSystemDbContext = new EmersonWeatherSystemDbContext(dbOptions);


            var variables = TestVariables.GetTestVariables();
            _EmersonWeatherSystemDbContext.AddRange(variables);
            _EmersonWeatherSystemDbContext.SaveChanges();


            _ICityRepository = new CityRepository(_EmersonWeatherSystemDbContext);
        }

        [Fact]
        public async Task GetHottestCityTests()
        {
            //Act
            var hottestCity = await _ICityRepository.GetHottestCityAsync();

            // Assert
            hottestCity.ShouldBeOfType<HottestCityDto>();
            hottestCity.CityName.ShouldBe("Kuala Lumpur");
            hottestCity.NumOfDaysOver30C.ShouldBe(7);
        }

        [Fact]
        public async Task GetMoistestCityTests()
        {
            //Act
            var moistestCity = await _ICityRepository.GetMoistestCityAsync();

            // Assert
            moistestCity.ShouldBeOfType<MoistestCityDto>();
            moistestCity.CityName.ShouldBe("Singapore");
            moistestCity.AverageHumidity.ShouldBe(48.5m);
        }
    }
}
