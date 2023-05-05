using AutoMapper;
using Emerson.WeatherSystem.Application.Dtos;
using Emerson.WeatherSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.MappingProfiles
{
    public class WeatherSystemProfile : Profile
    {
        public WeatherSystemProfile() 
        {
            CreateMap<CityDto, City>().ReverseMap();
            CreateMap<VariableDto, Variable>().ReverseMap();
        }
    }
}
