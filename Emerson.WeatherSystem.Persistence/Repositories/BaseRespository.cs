using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace Emerson.WeatherSystem.Persistence.Repositories
{
    public abstract class BaseRespository
    {
        private static string? m_connectionString = Environment.GetEnvironmentVariable("emerson-db-ConnectionString");

        protected DbConnection GetConnection()
        {
            DbConnectionStringBuilder connectionString = new DbConnectionStringBuilder();
            connectionString.ConnectionString = m_connectionString; // throws

            var connection = new SqlConnection(connectionString.ConnectionString);
            return connection;
        }

    }
}
