using example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.Repository
{
    public interface IClientRepository
    {
        public Task<List<ClientModel>> GetAllClient();
        public  Task AddDataasync(ClientModel clientModel);
        public Task<ClientModel> GetByIdasync(int id);

    }
}