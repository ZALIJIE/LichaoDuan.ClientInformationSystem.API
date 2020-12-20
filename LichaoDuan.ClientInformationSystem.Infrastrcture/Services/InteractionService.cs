using LichaoDuan.ClientInformationSystem.Core.Models.Response;
using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Services
{
    public class InteractionService:IInteractionService
    {

        private readonly IInterationRepository _interactionRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IClientRepository _clientRepository;
        public InteractionService(IInterationRepository InteractionRepository, IEmployeeRepository EmployeeRepository, IClientRepository ClientRepository)
        {
            _interactionRepository = InteractionRepository;
            _employeeRepository = EmployeeRepository;
            _clientRepository = ClientRepository;
        }

        //Return all Interaction information by list of interaction id
        public async Task<IEnumerable<InteractionResponseModel>> GetAllInteractionInfos(IEnumerable<int> idList)
        {
            var responses = new List<InteractionResponseModel>();
            foreach (var id in idList)
            {
                responses.Add(await GetInteractionInfoByInteractionId(id));
            }
            return responses;
        }

        //return interaction response model by interaction id
        public async Task<InteractionResponseModel> GetInteractionInfoByInteractionId(int id)
        {
            var employee=await _interactionRepository.GetEmployeeByInteractionId(id);
            var client = await _interactionRepository.GetClientByInteractionId(id);
            var interaction = await _interactionRepository.GetByIdAsync(id);
            var response = new InteractionResponseModel
            {
                interactionId=interaction.Id,
                employeeName=employee.Name,
                employeeDesignation=employee.Designation,
                clientName=client.Name,
                clientEmail=client.Email,
                clientPhone=client.Phones,
                intType=interaction.IntType,
                IntDate=interaction.IntDate,
                remarks=interaction.Remarks
            };
            return response;
        }

        //return a list of all interaction records by using employee id
        public async Task<IEnumerable<InteractionResponseModel>> GetInteractionsInfoByEmployeeId(int employeeId)
        {
            var idList =await _employeeRepository.GetInteractionIdByEmployeeId(employeeId);
            var responses = new List<InteractionResponseModel>();
            foreach(var id in idList)
            {
                var response =await GetInteractionInfoByInteractionId(id);
                responses.Add(response);
            }
            return responses;
        }

        //return a list of all interaction records by employee id
        public async Task<IEnumerable<InteractionResponseModel>> GetInteractionsInfoByClientId(int clientId)
        {
            var idList = await _clientRepository.GetInteractionIdByClientId(clientId);
            var responses = new List<InteractionResponseModel>();
            foreach(var id in idList)
            {
                var response = await GetInteractionInfoByInteractionId(id);
                responses.Add(response);
            }
            return responses;
        }


    }
}
