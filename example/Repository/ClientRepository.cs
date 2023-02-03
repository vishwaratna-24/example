using example.Entities;
using example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;
        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
          
        }
        public async Task<List<ClientModel>> GetAllClient()
        {
            var record = await _context.MyProperty.Select(x => new ClientModel()
            {
                Id = x.id,
                name = x.name,
                Designation = x.Designation

            }

            ).ToListAsync();

            return  record;
        }
        public async Task AddDataasync(ClientModel clientModel)
        {
            Client CM = new Client()
            {
                id = clientModel.Id,
                name = clientModel.name,
                Designation = clientModel.Designation
            };
            _context.MyProperty.Add(CM);
            await _context.SaveChangesAsync();

        }
        public async Task<ClientModel> GetByIdasync(int id)
        {
            var data = await _context.MyProperty.Where(i => i.id == id).Select(x => new ClientModel()
            {
                Id = x.id,
                name = x.name,
                Designation = x.Designation
            }).FirstOrDefaultAsync();
            return data;

        }


    }
}
