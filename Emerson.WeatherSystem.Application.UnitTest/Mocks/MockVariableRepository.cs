using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Features.Queries;
using Emerson.WeatherSystem.Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.UnitTest.Mocks
{
    public class MockVariableRepository
    {
        public static Mock<IVariableRepository> GetMockVariableRepository()
        {
            var variableList = new List<Variable>
            {
                new Variable
                {
                    Id = 1,
                    TimeStamp = DateTimeOffset.Parse("2023-01-01T00:00:00.0000000+00:00"),
                    Name = "Temperature",
                    Unit = "°C",
                    Value = "20",
                    CityId = 1,
                },
                new Variable
                {
                    Id = 2,
                    TimeStamp = DateTimeOffset.Parse("2023-01-02T00:00:00.0000000+00:00"),
                    Name = "Temperature",
                    Unit = "°C",
                    Value = "21",
                    CityId = 1,
                },
                new Variable
                {
                    Id = 3,
                    TimeStamp = DateTimeOffset.Parse("2023-01-03T00:00:00.0000000+00:00"),
                    Name = "Temperature",
                    Unit = "°C",
                    Value = "22",
                    CityId = 1,
                }
            };

            var mockRepo = new Mock<IVariableRepository>();

            mockRepo.Setup(r => r.GetVariablesAsync(It.IsAny<GetVariablesQuery>())).ReturnsAsync(variableList);
            mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(variableList);

            return mockRepo;

        }

    }
}
