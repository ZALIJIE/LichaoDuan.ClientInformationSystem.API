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
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService ClientService)
        {
            _clientService = ClientService;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetClientInteraction(int id)
        {
            var interaction =await _clientService.GetInteractionInfo(id);
            return Ok(interaction);
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetAllEmployees()
        {
            var clients = await _clientService.GetAllClients();
            return Ok(clients);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> CreateClient(CreateClientRequestModel requestModel)
        {
            var response = await _clientService.CreateClient(requestModel);
            return Ok(new { message = "Client created succeed" });
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> UpdateClient(CreateClientRequestModel requestModel)
        {
            var response = await _clientService.UpdateClient(requestModel);
            return Ok(new { message = "Client updated succeed" });
        }

        [HttpDelete]
        [Route("delete")]
        public async Task DeleteClient(CreateClientRequestModel requestModel)
        {
            await _clientService.DeleteClient(requestModel);
        }
    }
}
