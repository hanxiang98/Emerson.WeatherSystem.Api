using Emerson.WeatherSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.IntergrationTests.TestData
{
    public class TestCities
    {
        public TestCities() { }

        public static IEnumerable<City> GetTestCities()
        {
            var cities = new List<City>();

            cities.Add(new City
            {
                Id = 1,
                CityName = "Singapore"
            });
            cities.Add(new City
            {
                Id = 2,
                CityName = "Kuala Lumpur"
            });

            return cities;
        }
    }
}
