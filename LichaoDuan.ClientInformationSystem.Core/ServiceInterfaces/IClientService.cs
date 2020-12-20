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

    }
}
