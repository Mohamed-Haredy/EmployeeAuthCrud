
using EmployeeAuthCrud.Domain.Entities;

namespace EmployeeAuthCrud.UI.Services
{
    public interface ICountryDataService
    {

        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryDetails(int employeeId);
    }
}
