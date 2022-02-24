using Microsoft.EntityFrameworkCore;
using PetSpa.Data.Common.Repositories;
using PetSpa.Data.Models;
using PetSpa.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetSpa.Services.Data
{
    public class PetService : IPetService
    {
        private readonly IDeletableEntityRepository<Pet> serviceRepository;

        public PetService(IDeletableEntityRepository<Pet> serviceRepository)
        {
            this.serviceRepository = serviceRepository;
        }


        public async Task<IEnumerable<T>> GetAllServices<T>()
        {
            return await this.serviceRepository
            .AllAsNoTracking()
            .To<T>()
            .ToArrayAsync();
        }
    }
}
