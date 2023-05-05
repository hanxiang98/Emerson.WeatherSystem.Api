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
    public class GetMoistestCityQueryHandler : IRequestHandler<GetMoistestCityQuery, MoistestCityDto>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public GetMoistestCityQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }


        public async Task<MoistestCityDto> Handle(GetMoistestCityQuery request, CancellationToken cancellationToken)
        {
            var result = await _cityRepository.GetMoistestCityAsync();

            return result;
        }

    }
}
