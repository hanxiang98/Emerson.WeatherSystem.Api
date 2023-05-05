using AutoMapper;
using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Features.Queries
{
    public class GetAllCitiesWithVariableQueryHandler : IRequestHandler<GetAllCitiesWithVariableQuery, List<CityDto>>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public GetAllCitiesWithVariableQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }


        public async Task<List<CityDto>> Handle(GetAllCitiesWithVariableQuery request, CancellationToken cancellationToken)
        {// select from database
            var result = await _cityRepository.GetAllCitiesWithVariableAsync();

            // convert to dto object
            var cityDtos = _mapper.Map<List<CityDto>>(result);

            return cityDtos;
        }
    }
}
