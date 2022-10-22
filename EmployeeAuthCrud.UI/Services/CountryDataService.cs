
using EmployeeAuthCrud.Domain.Entities;
using System.Text;
using System.Text.Json;

namespace EmployeeAuthCrud.UI.Services
{

    public class CountryDataService : ICountryDataService
    {
        private readonly HttpClient httpClient;
        public CountryDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        async Task<IEnumerable<Country>> ICountryDataService.GetAllCountries()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>
                (await httpClient.GetStreamAsync("/api/Country"), new JsonSerializerOptions()
                { PropertyNameCaseInsensitive = true });
#pragma warning restore CS8603 // Possible null reference return.
        }

        public Task<Country> GetCountryDetails(int CountryId)
        {
            throw new NotImplementedException();
        }
    }
}
