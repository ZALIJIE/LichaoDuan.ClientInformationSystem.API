using LichaoDuan.ClientInformationSystem.Core.Models.Response;
using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Services
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository ClientRepository)
        {
            _clientRepository = ClientRepository;
        }

        //public async Task<ClientInteractionResponseModel> GetInteractionInfo(int id)
        //{
        //    var interaction = await _clientRepository.GetInteractionByClientId(id);
        //    var EmpInfo = await _clientRepository.GetEmployeeByClientId(id);
        //    var response = new ClientInteractionResponseModel
        //    {
        //        Id = interaction.Id,
        //        IntType = interaction.IntType,
        //        IntDate = interaction.IntDate,
        //        Remarks = interaction.Remarks,
        //        EmpInfo = new EmployeeResponseModel()
        //    };
        //    response.EmpInfo.Id = EmpInfo.Id;
        //    response.EmpInfo.EmpName = EmpInfo.Name;
        //    response.EmpInfo.Designation = EmpInfo.Designation;
        //    return response;
        //}

        public async Task<IEnumerable<ClientResponseModel>> GetAllClients()
        {
            var clients = await _clientRepository.ListAllAsync();
            var response = new List<ClientResponseModel>();
            foreach (var client in clients)
            {
                response.Add(new ClientResponseModel
                {
                    ClientId=client.Id,
                    ClientName=client.Name,
                    ClientPhone=client.Phones,
                    ClientAddress=client.Address
                });
            }
            return response;
        }

        public Task<ClientInteractionResponseModel> GetInteractionInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
