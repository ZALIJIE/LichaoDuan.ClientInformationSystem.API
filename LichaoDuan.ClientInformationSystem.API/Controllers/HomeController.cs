using LichaoDuan.ClientInformationSystem.Core.Models.Response;
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

    public class HomeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IClientService _clientServie;
        public HomeController(IEmployeeService EmployeeService, IClientService ClientService)
        {
            _employeeService = EmployeeService;
            _clientServie = ClientService;
        }
    }
}
