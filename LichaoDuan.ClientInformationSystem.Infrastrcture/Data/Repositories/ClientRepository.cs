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

        public Task<Employee> GetEmployeeByClientId(int id)
        {
            throw new NotImplementedException();
        }



        public async Task<Interaction> GetInteractionByClientId(int id)
        {
            var iteraction = await _clientInformationSystemDbContext.Interactions.FirstOrDefaultAsync(i => i.ClientId == id);
            return iteraction;
        }
    }
}
