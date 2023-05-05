using AutoMapper;
using Emerson.WeatherSystem.Application.Contracts.Persistence;
using Emerson.WeatherSystem.Application.Dtos;
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
            var result = await _variableRepository.GetVariables(request);
            var dtos = _mapper.Map<List<VariableDto>>(result);

            return dtos;
        }
    }
}
