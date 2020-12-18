using LichaoDuan.ClientInformationSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LichaoDuan.ClientInformationSystem.Infrastrcture.Data.Repositories
{
    public class InteractionRepository:EfRepository<Interaction>
    {
        protected readonly ClientInformationSystemDbContext _clientInformationSystemDb;

        public InteractionRepository(ClientInformationSystemDbContext dbContext) :base(dbContext)
        {
            _clientInformationSystemDb = dbContext;
        }
    }
}
