
namespace Emerson.WeatherSystem.Application.Exceptions;

public class BadRequestException : Exception
{
    public IDictionary<string, string[]> Errors { get; set; }

    public BadRequestException(string name) : base()
    {

    }
}


