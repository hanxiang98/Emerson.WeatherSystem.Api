using Emerson.WeatherSystem.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.Features.Queries;

public record GetHottestCityQuery() : IRequest<HottestCityDto>;