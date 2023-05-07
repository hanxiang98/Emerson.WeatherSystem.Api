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
    public class GetHottestCityQueryHandlerTests
    {
        private readonly Mock<ICityRepository> _mockRepo;
        private IMapper _mapper;

        public GetHottestCityQueryHandlerTests()
        {
            _mockRepo = MockCityRepository.GetMockCityRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<WeatherSystemProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetHottestCityTests()
        {
            var handler = new GetHottestCityQueryHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetHottestCityQuery(), CancellationToken.None);

            result.ShouldBeOfType<HottestCityDto>();
            result.CityName.ShouldBe("Kuala Lumpur");
            result.NumOfDaysOver30C.ShouldBe(10);
        }
    }
}
