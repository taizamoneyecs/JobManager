using BackEnd.Domain.Client.Site;

namespace BackEnd.Application.Repository_Interfaces
{
    public interface IClientRepository<Client> : IDisposable where Client : class
    {
        
        IQueryable<Client> GetClientsByName(string name);
        IQueryable<Client> GetClientsbyID(Guid id);
        IQueryable<Site> GetSitesByClientID(Guid clientId);


        Task AddAsync(Client entity);
        Task DeleteAsync(Client entity);
        Task UpdateAsync(Client entity);
        Task AddSiteAsync(Site site);
        Task DeleteSiteAsync(Site site);


    }
}
