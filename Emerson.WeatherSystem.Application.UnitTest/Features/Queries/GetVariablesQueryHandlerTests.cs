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
    public class GetVariablesQueryHandlerTests
    {
        private readonly Mock<IVariableRepository> _mockRepo;
        private IMapper _mapper;

        public GetVariablesQueryHandlerTests()
        {
            _mockRepo = MockVariableRepository.GetMockVariableRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<WeatherSystemProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetVariablesTests()
        {
            var handler = new GetVariablesQueryHandler(_mockRepo.Object, _mapper);

            var query = new GetVariablesQuery();
            query.CityName = "Singapore";
            query.VariableName = "Temperature";

            var result = await handler.Handle(query, CancellationToken.None);
            /*
            var testing = await _mockRepo.Object.GetAllAsync();
            Console.WriteLine(testing);
            */
            result.ShouldBeOfType<List<VariableDto>>(); 
            result.Count.ShouldBe(3);
        }
    }
}
