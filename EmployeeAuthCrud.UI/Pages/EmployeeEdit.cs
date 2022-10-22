using EmployeeAuthCrud.Domain.Entities;
using EmployeeAuthCrud.UI.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeAuthCrud.UI.Pages
{
    public partial class EmployeeEdit
    {
        [Parameter]
        public int EmployeeId { get; set; }

        Employee Employee = new Employee();
 

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
         



        protected bool Saved;

        //used to show state of form
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
           


            if (Employee == null) //new employee is being created
            {

                Employee = new Employee();

            }

        }

        protected async void HandleValidSubmit()
        {
            Saved = false;

            if (Employee.EmployeeId == 0) //new
            {
                await EmployeeDataService.AddEmployee(Employee);

                StatusClass = "alert-success";
                Message = "New employee added successfully.";
                Saved = true;
            }
            else //edit existing
            {
                await EmployeeDataService.UpdateEmployee(Employee);
                
                StatusClass = "alert-success";
                Message = "Employee updated successfully.";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }
    }


}
