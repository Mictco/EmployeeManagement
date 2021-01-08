using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Shared;
using EmployeeManager.Server.Interface;
namespace EmployeeManager.Server.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee objemployee;

        public EmployeeController(IEmployee _objemployee)
        {
            objemployee = _objemployee;
        }

        [HttpGet]
        public Task<List<Employee>> Get()
        {
            return objemployee.GetAllEmployees();
        }

        [HttpGet("{id}")]
        public Task<Employee> Get(string id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            objemployee.AddEmployee(employee);
        }

        [HttpPut]
        public void Put([FromBody] Employee employee)
        {
            objemployee.UpdateEmployee(employee);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            objemployee.DeleteEmployee(id);

        }
        [HttpGet("GetCities")]
        public Task<List<Cities>> GetCities()
        {
            return objemployee.GetCityData();
        }
    }
}
