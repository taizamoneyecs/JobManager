using BackEnd.Domain.Client;
using BackEnd.Domain.Client.Site;

namespace BackEnd.Application.Repository_Interfaces
{
    public interface IClientRepository
    {
        Task AddAsync (Client client);
        Task DeleteAsync (Client id);
        Task UpdateAsync (Client client);
        Task <List<Client>> GetByNameAsync (string name);
        Task<List<Client>> GetAllAsync ();

        
        Task AddSiteAsync (Site site);
        Task DeleteSiteAsync (Guid siteId);
        Task<List<Site>> GetSitesByClientIdAsync(Guid clientId);


    }
}
