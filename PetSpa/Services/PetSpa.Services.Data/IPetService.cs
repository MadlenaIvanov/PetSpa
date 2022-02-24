using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetSpa.Services.Data
{
    public interface IPetService
    {
        Task<IEnumerable<T>> GetAllServices<T>();
    }
}
