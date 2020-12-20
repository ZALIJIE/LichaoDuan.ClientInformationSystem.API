using LichaoDuan.ClientInformationSystem.Core.Models.Request;
using LichaoDuan.ClientInformationSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces
{
    public interface IClientService
    {
        Task<ClientInteractionResponseModel> GetInteractionInfo(int id);
        Task<IEnumerable<ClientResponseModel>> GetAllClients();
        Task<CreateClientRequestModel> CreateClient(CreateClientRequestModel requestModel);
        Task<CreateClientRequestModel> UpdateClient(CreateClientRequestModel requestModel);
        Task DeleteClient(CreateClientRequestModel requestModel);
    }
}
