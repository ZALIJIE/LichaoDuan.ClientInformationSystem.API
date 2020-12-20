using LichaoDuan.ClientInformationSystem.Core.Models.Response;
using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
            _employeeRepository = EmployeeRepository;
        }

        //public async Task<EmployeeIteractionResponseModel> GetInteractionInfo(int id)
        //{
        //    var interaction = await _employeeRepository.GetInteractionByEmployeeId(id);
        //    var client = await _employeeRepository.GetClientByEmployeeId(id);
        //    var response = new EmployeeIteractionResponseModel
        //    {
        //        Id = interaction.Id,
        //        IntType = interaction.IntType,
        //        IntDate = interaction.IntDate,
        //        Remarks = interaction.Remarks,
        //        ClientInfo = new ClientResponseModel()
        //    };
        //    response.ClientInfo.ClientId = client.Id;
        //    response.ClientInfo.ClientName=client.Name;
        //    response.ClientInfo.ClientPhone = client.Phones;
        //    response.ClientInfo.ClientAddress = client.Address;

        //    return response;
        //}

        public async Task<IEnumerable<EmployeeResponseModel>> GetAllEmployees()
        {
            var employees = await _employeeRepository.ListAllAsync();
            var response = new List<EmployeeResponseModel>();
            foreach(var employee in employees)
            {
                response.Add(new EmployeeResponseModel
                {
                    Id=employee.Id,
                    EmpName=employee.Name,
                    Designation=employee.Designation
                });
            }
            return response;
        }

        public Task<EmployeeIteractionResponseModel> GetInteractionInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
