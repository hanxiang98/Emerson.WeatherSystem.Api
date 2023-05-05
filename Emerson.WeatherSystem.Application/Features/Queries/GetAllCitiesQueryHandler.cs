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
    public class GetAllCitiesQueryHandler : IRequestHandler<GetAllCitiesQuery, List<CityDto>>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public GetAllCitiesQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }


        public async Task<List<CityDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {// select from database
            var result = await _cityRepository.GetAllAsync();

            // convert to dto object
            var cityDtos = _mapper.Map<List<CityDto>>(result);

            return cityDtos;
        }
    }
}
