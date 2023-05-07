using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.UnitTest.Mocks
{
    public class MockCityRepository
    {
        public static Mock<ICityRepository> GetMockCityRepository()
        {
            HottestCityDto hottestCityDto = new HottestCityDto();
            hottestCityDto.CityName = "Kuala Lumpur";
            hottestCityDto.NumOfDaysOver30C = 10;

            MoistestCityDto moistestCityDto = new MoistestCityDto();
            moistestCityDto.CityName = "Singapore";
            moistestCityDto.AverageHumidity = 50;

            var mockRepo = new Mock<ICityRepository>();

            mockRepo.Setup(r => r.GetHottestCityAsync()).ReturnsAsync(hottestCityDto);
            mockRepo.Setup(r => r.GetMoistestCityAsync()).ReturnsAsync(moistestCityDto);

            return mockRepo;
        }
    }
}

