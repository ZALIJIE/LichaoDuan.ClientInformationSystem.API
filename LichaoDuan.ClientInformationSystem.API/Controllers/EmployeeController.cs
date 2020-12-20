using LichaoDuan.ClientInformationSystem.Core.Models.Request;
using LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService EmployeeService)
        {
            _employeeService = EmployeeService;
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetEmployeeInteractions(int id)
        {
            var interaction = await _employeeService.GetInteractionInfo(id);
            return Ok(interaction);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            return Ok(employees);
        }


        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> CreateEmployee(CreateEmployeeRequestModel requestModel)
        {
            var response=await _employeeService.CreateEmployee(requestModel);
            return Ok(new { message = "Employee created succeed" });
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> UpdateEmployee(CreateEmployeeRequestModel requestModel)
        {
            var response = await _employeeService.UpdateEmployee(requestModel);
            return Ok(new { message = "Client updated succeed" });
        }

        [HttpDelete]
        [Route("delete")]
        public async Task DeleteEmployee(CreateEmployeeRequestModel requestModel)
        {
            await _employeeService.DeleteEmployee(requestModel);
        }

    }
}
