using LichaoDuan.ClientInformationSystem.Core.Models.Request;
using LichaoDuan.ClientInformationSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces
{
    public interface IInteractionService
    {
        Task<InteractionResponseModel> GetInteractionInfoByInteractionId(int id);
        Task<IEnumerable<InteractionResponseModel>> GetAllInteractionInfos(IEnumerable<int> idList);
        Task<IEnumerable<InteractionResponseModel>> GetInteractionsInfoByEmployeeId(int id);
        Task<IEnumerable<InteractionResponseModel>> GetInteractionsInfoByClientId(int clientId);
        Task<CreateInteractionRequestModel> CreateInteraction(CreateInteractionRequestModel requestModel);

    }
}
