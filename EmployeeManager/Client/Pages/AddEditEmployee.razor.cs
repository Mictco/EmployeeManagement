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
    public class AddEditEmployeeModel : ComponentBase
    {
        [Inject]
        protected HttpClient Http { get; set; }
        [Inject]
        public NavigationManager UrlNavigationManager { get; set; }
        [Parameter]
        public string empID { get; set; }

        protected string Title = "Add";
        public Employee emp = new Employee();
        protected List<Cities> cityList = new List<Cities>();

        protected override async Task OnInitializedAsync()
        {
            await GetCityList();
        }

        protected override async Task OnParametersSetAsync()
        {
            if (!string.IsNullOrEmpty(empID))
            {
                Title = "Edit";
                emp = await Http.GetFromJsonAsync<Employee>("/api/Employee/" + empID);
            }
        }

        protected async Task GetCityList()
        {
            cityList = await Http.GetFromJsonAsync<List<Cities>>("api/Employee/GetCities");
        }

        protected async Task SaveEmployee()
        {
            if (emp.EmployeeId != null)
            {
                await Http.PutAsJsonAsync( "api/Employee/", emp);
            }
            else
            {
                await Http.PostAsJsonAsync( "/api/Employee/", emp);
            }
            Cancel();
        }

        public void Cancel()
        {
            UrlNavigationManager.NavigateTo("/employeerecords");
        }
    }
}
