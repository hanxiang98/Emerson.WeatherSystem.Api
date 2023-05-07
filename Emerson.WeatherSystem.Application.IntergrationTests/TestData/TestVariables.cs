using Emerson.WeatherSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emerson.WeatherSystem.Application.IntergrationTests.TestData
{
    public class TestVariables
    {
        public TestVariables() { }

        public static IEnumerable<Variable> GetTestVariables()
        {
            City singapore = new City
            {
                Id = 1,
                CityName = "Singapore"
            };

            City kl = new City
            {
                Id = 2,
                CityName = "Kuala Lumpur"
            };

            var variables = new List<Variable>();

            variables.Add(new Variable{ Id = 1, Name = "Temperature", Unit = "°C", Value = "30.0"
                , TimeStamp = DateTimeOffset.Parse("2023-01-01T00:00:00.0000000+00:00"), CityId = 1, City = singapore});
            variables.Add(new Variable { Id = 2, Name = "Temperature", Unit = "°C", Value = "31.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-02T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 3, Name = "Temperature", Unit = "°C", Value = "32.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-03T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 4, Name = "Temperature", Unit = "°C", Value = "33.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-04T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 5, Name = "Temperature", Unit = "°C", Value = "34.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-05T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 6, Name = "Temperature", Unit = "°C", Value = "35.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-06T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 7, Name = "Temperature", Unit = "°C", Value = "29.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-07T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 8, Name = "Temperature", Unit = "°C", Value = "28.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-08T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 9, Name = "Temperature", Unit = "°C", Value = "27.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-09T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 10, Name = "Temperature", Unit = "°C", Value = "26.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-10T00:00:00.0000000+00:00"), CityId = 1, City = singapore });

            variables.Add(new Variable{ Id = 11, Name = "Temperature", Unit = "°C", Value = "30.0"
                , TimeStamp = DateTimeOffset.Parse("2023-01-01T00:00:00.0000000+00:00"), CityId = 2, City = kl});
            variables.Add(new Variable { Id = 12, Name = "Temperature", Unit = "°C", Value = "31.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-02T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 13, Name = "Temperature", Unit = "°C", Value = "32.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-03T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 14, Name = "Temperature", Unit = "°C", Value = "33.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-04T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 15, Name = "Temperature", Unit = "°C", Value = "34.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-05T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 16, Name = "Temperature", Unit = "°C", Value = "35.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-06T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 17, Name = "Temperature", Unit = "°C", Value = "36.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-07T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 18, Name = "Temperature", Unit = "°C", Value = "37.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-08T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 19, Name = "Temperature", Unit = "°C", Value = "27.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-09T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 20, Name = "Temperature", Unit = "°C", Value = "26.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-10T00:00:00.0000000+00:00"), CityId = 2, City = kl });

            variables.Add(new Variable{ Id = 21, Name = "Humidity", Unit = "%", Value = "41.0"
                , TimeStamp = DateTimeOffset.Parse("2023-01-01T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 22, Name = "Humidity", Unit = "%", Value = "42.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-02T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 23, Name = "Humidity", Unit = "%", Value = "43.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-03T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 24, Name = "Humidity", Unit = "%", Value = "44.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-04T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 25, Name = "Humidity", Unit = "%", Value = "45.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-05T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 26, Name = "Humidity", Unit = "%", Value = "46.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-06T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 27, Name = "Humidity", Unit = "%", Value = "47.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-07T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 28, Name = "Humidity", Unit = "%", Value = "48.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-08T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 29, Name = "Humidity", Unit = "%", Value = "49.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-09T00:00:00.0000000+00:00"), CityId = 2, City = kl });
            variables.Add(new Variable { Id = 30, Name = "Humidity", Unit = "%", Value = "50.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-10T00:00:00.0000000+00:00"), CityId = 2, City = kl });

            variables.Add(new Variable{ Id = 31, Name = "Humidity", Unit = "%", Value = "51.0"
                , TimeStamp = DateTimeOffset.Parse("2023-01-01T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 32, Name = "Humidity", Unit = "%", Value = "52.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-02T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 33, Name = "Humidity", Unit = "%", Value = "53.0",
                TimeStamp = DateTimeOffset.Parse("2023-01-03T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 34, Name = "Humidity", Unit = "%", Value = "44.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-04T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 35, Name = "Humidity", Unit = "%", Value = "45.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-05T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 36, Name = "Humidity", Unit = "%", Value = "46.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-06T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 37, Name = "Humidity", Unit = "%", Value = "47.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-07T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 38, Name = "Humidity", Unit = "%", Value = "48.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-08T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 39, Name = "Humidity", Unit = "%", Value = "49.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-09T00:00:00.0000000+00:00"), CityId = 1, City = singapore });
            variables.Add(new Variable { Id = 40, Name = "Humidity", Unit = "%", Value = "50.0", 
                TimeStamp = DateTimeOffset.Parse("2023-01-10T00:00:00.0000000+00:00"), CityId = 1, City = singapore });

            return variables;
        }
    }
}
