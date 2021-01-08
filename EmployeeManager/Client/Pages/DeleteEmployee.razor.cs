using EmployeeManager.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeManager.Client.Pages
{
    public class DeleteEmployeeData : ComponentBase
    {
        [Inject]
        protected HttpClient Http { get; set; }
        [Inject]
        public NavigationManager UrlNavigationManager { get; set; }
        [Parameter]
        public string empID { get; set; }
        public Employee emp = new Employee();

        protected override async Task OnParametersSetAsync()
        {
            if (!string.IsNullOrEmpty(empID))
            {
                emp = await Http.GetFromJsonAsync<Employee>("/api/Employee/" + empID);
            }
        }
        public void Cancel()
        {
            UrlNavigationManager.NavigateTo("/employeerecords");
        }
        protected async void DeleteConfirm(string empID)
        {
            emp = await Http.GetFromJsonAsync<Employee>("/api/Employee/" + empID);
        }
        protected async Task DeleteEmployee(string empID)
        {
            await Http.DeleteAsync("api/Employee/" + empID);
            Cancel();
        }
    }
}
