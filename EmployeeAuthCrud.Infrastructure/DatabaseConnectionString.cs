using EmployeeAuthCrud.Infrastructure;
 

namespace EmployeeAuthCrud.Infrastructure
{
    public class DatabaseConnectionString : IDatabaseConnectionString
    {
        public string ConnectionString { get; }

        public DatabaseConnectionString(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
