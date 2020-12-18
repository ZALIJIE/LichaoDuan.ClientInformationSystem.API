using LichaoDuan.ClientInformationSystem.Core.Entities;
using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Data.Repositories
{
    public class EmployeeRepository:EfRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ClientInformationSystemDbContext dbContext):base(dbContext)
        {

        }

        public async Task<Interaction> GetInteractionByEmployeeId(int id)
        {
            var iteraction = await _clientInformationSystemDbContext.Interactions.FirstOrDefaultAsync(i => i.EmployeeId == id);
            return iteraction;
        }

        
    }
}
