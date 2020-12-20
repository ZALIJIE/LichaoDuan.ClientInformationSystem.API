using LichaoDuan.ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces
{
    public interface IInterationRepository:IAsyncRepository<Interaction>
    {
        Task<Employee> GetEmployeeByInteractionId(int id);
        Task<Client> GetClientByInteractionId(int id);
    }
}
