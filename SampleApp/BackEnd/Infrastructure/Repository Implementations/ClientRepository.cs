using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Client;
using BackEnd.Domain.Client.Site;
using BackEnd.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;
        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
           
        }

        public async Task DeleteAsync(Guid id)
        {
            var client = _context.Clients.FindAsync(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();
            }
            
        }

        public async Task UpdateAsync(Client cleint)
        {
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();
        }
        
        
        public async Task<List<string>> GetClientsByNameAsync(string name)
        {
            var client =  await _context.Clients
                .Where(c => c.Name == name)
                .ToListAsync();
            return client;
            
        }

        public async Task AddSitesAsync(Site site)
        {
            _context.Sites.Add(site);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSiteAsync(Guid id)
        {
            var site = _context.Sites.FindAsync(id)
            if (site != null)
            {
                _context.Sites.Remove(site);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<List<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<List<Site>> GetSitesByClientIdAsync(Guid clientId)
        {
            var sites = await _context.Sites 
                .Where(s => s.ClientId == clientId)
                .ToListAsync();
            return sites;
        }



    }
}
