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
        public async Task<ActionResult> GetEmployeeInteraction(int id)
        {
            var interaction = await _employeeService.GetInteractionInfo(id);
            return Ok(interaction);
        }
    }
}
