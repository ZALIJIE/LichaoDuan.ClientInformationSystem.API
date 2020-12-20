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

        public async Task<IEnumerable<Interaction>> GetInteractionByClientId(int id)
        {
            var iteractions = await _clientInformationSystemDbContext.Interactions.Where(i => i.ClientId==id)
                .Include(i => i.Client)
                .Select(i => new Interaction
                {
                    Id=i.Id,
                    ClientId=i.ClientId,
                    EmployeeId=i.EmployeeId,
                    IntType=i.IntType,
                    IntDate=i.IntDate,
                    Remarks=i.Remarks
                })
                .ToListAsync();
            return iteractions;
        }

        public async Task<IEnumerable<int>> GetInteractionIdByClientId(int id)
        {
            var interactionId = await _clientInformationSystemDbContext.Interactions.Where(i => i.ClientId == id)
                .Include(i => i.Client)
                .Select(i=>i.Id)
                .ToListAsync();
            return interactionId;
        }
    }
}
