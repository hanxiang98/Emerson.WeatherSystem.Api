using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Emerson.WeatherSystem.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmersonWeatherSystemController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmersonWeatherSystemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/CBDDetailController/GetCBD/<CBDId>
        [HttpGet]
        [Route("GetAllCities/")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<CityDto>>> GetAllCities()
        {
            var cityList = await _mediator.Send(new GetAllCitiesQuery());
            return Ok(cityList);
        }

        [HttpGet]
        [Route("GetAllCitiesWithVariable/")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<CityDto>>> GetAllCitiesWithVariable()
        {
            var cityList = await _mediator.Send(new GetAllCitiesWithVariableQuery());
            return Ok(cityList);
        }

        [HttpPost]
        [Route("GetVariables/")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<VariableDto>>> GetVariables(GetVariablesQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("GetHottestCity/")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HottestCityDto>> GetHottestCity()
        {
            var result = await _mediator.Send(new GetHottestCityQuery());
            return Ok(result);
        }

        [HttpGet]
        [Route("GetMoistestCity/")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MoistestCityDto>> GetMoistestCity()
        {
            var result = await _mediator.Send(new GetMoistestCityQuery());
            return Ok(result);
        }
    }
}