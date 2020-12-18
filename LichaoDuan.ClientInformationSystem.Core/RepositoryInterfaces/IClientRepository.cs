using LichaoDuan.ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces
{
    public interface IClientRepository:IAsyncRepository<Client>
    {
        Task<Interaction> GetInteractionByClientId(int id);
        Task<Employee> GetEmployeeByClientId(int id);
    }
}
