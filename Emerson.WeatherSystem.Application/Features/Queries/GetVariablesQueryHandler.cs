using AutoMapper;
using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Features.Queries
{
    public class GetVariablesQueryHandler : IRequestHandler<GetVariablesQuery, List<VariableDto>>
    {
        private readonly IVariableRepository _variableRepository;
        private readonly IMapper _mapper;

        public GetVariablesQueryHandler(IVariableRepository variableRepository, IMapper mapper)
        {
            _variableRepository = variableRepository;
            _mapper = mapper;

        }
        public async Task<List<VariableDto>> Handle(GetVariablesQuery request, CancellationToken cancellationToken)
        {
            // Simple validation, for more complex validation will go with FluentValidation
            if(string.IsNullOrEmpty(request.VariableName) || string.IsNullOrEmpty(request.CityName))
            {
                throw new BadRequestException("GetVariablesQueryErrors", "Invalid get variable request, Variable and City name must not be empty.");
            }

            var result = await _variableRepository.GetVariablesAsync(request);

            if(result == null || result.Count() == 0)
            {
                throw new NotFoundException(nameof(List<VariableDto>), result);
            }

            var dtos = _mapper.Map<List<VariableDto>>(result);

            return dtos;
        }
    }
}
