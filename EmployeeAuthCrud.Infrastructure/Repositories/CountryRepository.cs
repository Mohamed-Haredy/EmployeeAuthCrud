using EmployeeAuthCrud.Domain.Entities;
 

namespace EmployeeAuthCrud.Infrastructure.Repositories
{
    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(EmployeeAuthCrudDBContext dbContext) : base(dbContext)
        {
        }
    }
}
