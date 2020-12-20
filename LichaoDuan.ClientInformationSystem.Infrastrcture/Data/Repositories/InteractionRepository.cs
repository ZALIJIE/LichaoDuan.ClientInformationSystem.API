using LichaoDuan.ClientInformationSystem.Core.Entities;
using LichaoDuan.ClientInformationSystem.Core.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Data.Repositories
{
    public class InteractionRepository : EfRepository<Interaction>,IInterationRepository
    {
        protected readonly ClientInformationSystemDbContext _clientInformationSystemDb;

        public InteractionRepository(ClientInformationSystemDbContext dbContext) :base(dbContext)
        {
            _clientInformationSystemDb = dbContext;
        }

        public async Task<Client> GetClientByInteractionId(int id)
        {
            var client=await _clientInformationSystemDb.Clients.Include(i =>i.Interaction)
                .FirstOrDefaultAsync(i=>i.Id==id);
            return client;
        }

        public async Task<Employee> GetEmployeeByInteractionId(int id)
        {
            var employee = await _clientInformationSystemDb.Employees.Include(i => i.Interaction)
                .FirstOrDefaultAsync(i => i.Id == id);
            return employee;
        }
    }
}
