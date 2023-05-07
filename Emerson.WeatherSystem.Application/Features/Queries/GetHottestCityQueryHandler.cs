using AutoMapper;
using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Features.Queries
{
    public class GetHottestCityQueryHandler : IRequestHandler<GetHottestCityQuery, HottestCityDto>
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;

        public GetHottestCityQueryHandler(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;
        }


        public async Task<HottestCityDto> Handle(GetHottestCityQuery request, CancellationToken cancellationToken)
        {
            var result = await _cityRepository.GetHottestCityAsync();

            if (result == null)
            {
                throw new NotFoundException(nameof(HottestCityDto), request);
            }

            return result;
        }

    }
}
