using LichaoDuan.ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces
{
    public interface IEmployeeRepository:IAsyncRepository<Employee>
    {
        Task<Interaction> GetInteractionByEmployeeId(int id);
    }
}
