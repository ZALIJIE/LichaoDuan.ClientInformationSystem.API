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
    public class InteractionController : ControllerBase
    {
        private readonly IInteractionService _interactionService;
        public InteractionController(IInteractionService Interactionservice)
        {
            _interactionService = Interactionservice;
        }

        [HttpGet]
        [Route("{interactionId:int}")]
        public async Task<IActionResult> GetInteractionsByIteractionId(int interactionId)
        {
            var interaction = await _interactionService.GetInteractionInfoByInteractionId(interactionId);
            return Ok(interaction);
        }

        [HttpGet]
        [Route("employee/{employeeId:int}")]
        public async Task<IActionResult> GetInteractionByEmployeeId(int employeeId)
        {
            var interaction = await _interactionService.GetInteractionsInfoByEmployeeId(employeeId);
            return Ok(interaction);
        }

        [HttpGet]
        [Route("client/{clientId:int}")]
        public async Task<IActionResult> GetInteractionByClientId(int clientId)
        {
            var interaction = await _interactionService.GetInteractionsInfoByClientId(clientId);
            return Ok(interaction);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateInteraction(CreateInteractionRequestModel requestModel)
        {
            var response = await _interactionService.CreateInteraction(requestModel);
            return Ok(new { message = "Employee created succeed" });
        }
    }
}
