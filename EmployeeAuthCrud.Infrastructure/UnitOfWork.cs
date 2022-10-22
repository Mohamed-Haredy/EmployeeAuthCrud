using EmployeeAuthCrud.Domain;
using EmployeeAuthCrud.Domain.Base; 
using EmployeeAuthCrud.Domain.Entities;
using Microsoft.Extensions.Logging; 
using EmployeeAuthCrud.Infrastructure.Repositories;
 

namespace EmployeeAuthCrud.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly EmployeeAuthCrudDBContext dbContext;
        private readonly ILogger<UnitOfWork> logger;

        public UnitOfWork(IDatabaseConnectionString databaseConnectionString, ILogger<UnitOfWork> logger)
        {
            dbContext = new EmployeeAuthCrudDBContext(databaseConnectionString.ConnectionString);
            this.logger = logger;
        }

        private IEmployeeRepository employeeRepository;
        private ICountryRepository  countryRepository;


        public IEmployeeRepository EmployeeRepository => employeeRepository ??= new EmployeeRepository(dbContext);
        public ICountryRepository CountryRepository => countryRepository ??= new CountryRepository(dbContext);



        public IRepository<T> AsyncRepository<T>() where T : Entity
        {
            return new RepositoryBase<T>(dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
        /// <summary>
        /// No matter an exception has been raised or not, 
        /// this method always will dispose the DbContext 
        /// </summary>
        /// <returns></returns>
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            return dbContext.DisposeAsync();
        } 
    }
}