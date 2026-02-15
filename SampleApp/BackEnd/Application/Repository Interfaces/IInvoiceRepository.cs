using BackEnd.Domain.Invoice;
namespace BackEnd.Application.Repository_Interfaces
{
    public interface IInvoiceRepository
    {
        Task AddAsync(Invoice invoice);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(Invoice invoice);

        Task<List<Invoice> GetAllAsync();
        Task <Invoice?> GetInvoiceByIDAsync(Guid id);
        Task<List<Invoice>> GetInvoicesByClientIDAsync(Guid clientId);
        Task<List<Invoice>> GetInvoicesByDateCreatedAsync(DateTime date);


    }
}
