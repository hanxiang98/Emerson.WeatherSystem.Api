
namespace Emerson.WeatherSystem.Application.Exceptions;

public class BadRequestException : Exception
{
    public IDictionary<string, string[]> Errors { get; set; }

    public BadRequestException(string name) : base()
    {
    }

    public BadRequestException(string name, string errorMessage) : base()
    {
        Dictionary<string, string[]> validationErrors = new Dictionary<string, string[]>();

        string[] errors = new string[]
        {
            errorMessage
        };
        validationErrors.Add(name, errors);

        this.ValidationErrors = validationErrors;
    }

    public BadRequestException(string name, IDictionary<string, string[]> validationErrors) : base()
    {
        ValidationErrors = validationErrors;
    }

    public IDictionary<string, string[]> ValidationErrors { get; set; }
}


