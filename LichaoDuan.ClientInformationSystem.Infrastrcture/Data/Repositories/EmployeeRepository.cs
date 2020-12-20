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
    public class EmployeeRepository:EfRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ClientInformationSystemDbContext dbContext):base(dbContext)
        {

        }

        public async Task<Client> GetClientByEmployeeId(int id)
        {
            var client= await _clientInformationSystemDbContext.Clients.Include(c => c.Interaction).ThenInclude(i => i.Employee).FirstOrDefaultAsync(c => c.Id == id);
            return client;
        }

        public async Task<IEnumerable<Interaction>> GetInteractionByEmployeeId(int id)
        {
            var iteractions = await _clientInformationSystemDbContext.Interactions.Where(i => i.EmployeeId==id)
                .Include(i => i.Employee)
                .Select(i => new Interaction
                {
                    Id = i.Id,
                    ClientId = i.ClientId,
                    EmployeeId = i.EmployeeId,
                    IntType = i.IntType,
                    IntDate = i.IntDate,
                    Remarks = i.Remarks
                }).ToListAsync();
            return iteractions;
        }

        public async Task<IEnumerable<int>> GetInteractionIdByEmployeeId(int id)
        {
            var iteractionId = await _clientInformationSystemDbContext.Interactions.Where(i => i.EmployeeId == id)
                .Include(i => i.Employee)
                .Select(i => i.Id)
                .ToListAsync();
            return iteractionId;
        }
    }
}
