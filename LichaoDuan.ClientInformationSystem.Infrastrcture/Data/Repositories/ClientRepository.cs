using LichaoDuan.ClientInformationSystem.Core.Entities;
using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Data.Repositories
{
    public class ClientRepository : EfRepository<Client>, IClientRepository
    {
        public ClientRepository(ClientInformationSystemDbContext dbContext):base(dbContext)
        {

        }

        public async Task<Employee> GetEmployeeByClientId(int id)
        {
            var emp = await _clientInformationSystemDbContext.Employees.Include(e => e.Interaction).ThenInclude(i => i.Client).FirstOrDefaultAsync(e => e.Id == id);
            return emp;
        }



        public async Task<Interaction> GetInteractionByClientId(int id)
        {
            var iteraction = await _clientInformationSystemDbContext.Interactions.FirstOrDefaultAsync(i => i.ClientId == id);
            return iteraction;
        }
    }
}
