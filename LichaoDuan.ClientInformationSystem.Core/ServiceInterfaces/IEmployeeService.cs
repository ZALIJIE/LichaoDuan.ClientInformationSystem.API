using LichaoDuan.ClientInformationSystem.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Core.ServiceInterfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeIteractionResponseModel> GetInteractionInfo(int id);
        Task<IEnumerable<EmployeeResponseModel>> GetAllEmployees();

    }
}
