using EmployeeAuthCrud.Domain.Entities;
using EmployeeAuthCrud.UI.Services;
using Microsoft.AspNetCore.Components;

 

namespace EmployeeAuthCrud.UI.Pages
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee curEmp { get; set; }


        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            curEmp = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
        }
    }
}
