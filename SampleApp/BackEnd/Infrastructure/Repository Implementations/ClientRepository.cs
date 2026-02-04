using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Client;
using BackEnd.Domain.Client.Site;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class ClientRepository : IClientRepository<Client>, IDisposable
    {
        private readonly AppDbContext _context;
        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Client> GetClientsbyID(Guid id)
        {
            return _context.Clients.Where(c => c.ID == id);
        }
        public IQueryable<Client> GetClientsByName(string name)
        {
            return _context.Clients.Where(c => c.Name == name);
        }
        
        public async Task AddAsync(Client entity)
        {
            await _context.Clients.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Client entity)
        {
            _context.Clients.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Client entity)
        {
            _context.Clients.Update(entity);
            await _context.SaveChangesAsync();
        }
        public IQueryable<Site> GetSitesByClientID(Guid clientId)
        {
            return _context.Sites.Where(s => s.ClientID == clientId);
        }
        public async Task AddSiteAsync(Site site)
        {
            await _context.Sites.AddAsync(site);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSiteAsync(Site site)
        {
            _context.Sites.Remove(site);
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            ((IDisposable)_context).Dispose();
        }
    }
}
