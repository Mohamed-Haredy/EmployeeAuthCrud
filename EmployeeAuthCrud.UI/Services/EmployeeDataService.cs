
using EmployeeAuthCrud.Domain.Entities;
using System.Text;
using System.Text.Json;
 
using System.Net.Http;
 

namespace EmployeeAuthCrud.UI.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient httpClient;
        public EmployeeDataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        async Task<IEnumerable<Employee>> IEmployeeDataService.GetAllEmployees()
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>
                (await httpClient.GetStreamAsync("/api/Employee"), new JsonSerializerOptions()
                { PropertyNameCaseInsensitive = true });
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId) => await JsonSerializer.DeserializeAsync<Employee>
(await httpClient.GetStreamAsync("/api/Employee/" + employeeId), new JsonSerializerOptions()
{ PropertyNameCaseInsensitive = true });

        public async Task AddEmployee(Employee employee)
        {
            var empObjSer = new StringContent(JsonSerializer.Serialize(employee),
                Encoding.UTF8, "application/json");

                await httpClient.PostAsync("/api/Employee/", empObjSer);
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        
        public async Task UpdateEmployee(Employee employee)
        {
            var empObjSer = new StringContent(JsonSerializer.Serialize(employee),
                Encoding.UTF8, "application/json");

            await httpClient.PutAsync("/api/Employee/"+employee.EmployeeId, empObjSer);
        }

     

      
    }
}
