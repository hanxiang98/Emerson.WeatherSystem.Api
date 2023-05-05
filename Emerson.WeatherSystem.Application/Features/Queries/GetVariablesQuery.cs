using Emerson.WeatherSystem.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Features.Queries;

public class GetVariablesQuery : IRequest<List<VariableDto>>
{
    public string VariableName { get; set; } = String.Empty;
    public DateTimeOffset StartTimeStamp { get; set; }
    public DateTimeOffset EndTimeStamp { get; set; }
    public string CityName { get; set; } = String.Empty;
}