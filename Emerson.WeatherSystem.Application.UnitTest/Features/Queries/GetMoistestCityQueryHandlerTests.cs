using AutoMapper;
using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Features.Queries;
using Emerson.WeatherSystem.Application.MappingProfiles;
using Emerson.WeatherSystem.Application.UnitTest.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.UnitTest.Features.Queries
{
    public class GetMoistestCityQueryHandlerTests
    {
        private readonly Mock<ICityRepository> _mockRepo;
        private IMapper _mapper;

        public GetMoistestCityQueryHandlerTests()
        {
            _mockRepo = MockCityRepository.GetMockCityRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<WeatherSystemProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetMoistestCityTests()
        {
            var handler = new GetMoistestCityQueryHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetMoistestCityQuery(), CancellationToken.None);

            result.ShouldBeOfType<MoistestCityDto>();
            result.CityName.ShouldBe("Singapore");
            result.AverageHumidity.ShouldBe(50);
        }
    }
}
