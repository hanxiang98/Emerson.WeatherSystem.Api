
using Emerson.WeatherSystem.Persistence.Interfaces;

namespace Emerson.WeatherSystem.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork()
        {
            //Imports = xmlImportRepository;
        }

        //public IXmlImportRepository Imports { get; }

    }
}
