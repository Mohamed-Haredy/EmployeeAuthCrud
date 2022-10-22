using EmployeeAuthCrud.Domain.Entities;
 
namespace EmployeeAuthCrud.UI.Services
{
    public class CountryDataService : ICountryDataService
    {
        public Task<IEnumerable<Country>> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Task<Country> GetCountryDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
