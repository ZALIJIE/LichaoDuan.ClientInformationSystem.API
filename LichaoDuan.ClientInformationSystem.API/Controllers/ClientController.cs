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
        private readonly IClientService _clientServie;
        public ClientController(IClientService ClientService)
        {
            _clientServie = ClientService;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult> GetClientInteraction(int id)
        {
            var interaction =await _clientServie.GetInteractionInfo(id);
            return Ok(interaction);
        }
    }
}
