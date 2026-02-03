namespace BackEnd.Application.Repository_Interfaces
{
    public interface IInvoiceRepository<Invoice> : IDisposable where Invoice : class
    {
        IQueryable<Invoice> GetAllInvoices();
        IQueryable<Invoice> GetInvoicesByID(Guid id);
        IQueryable<Invoice> GetInvoicesByClientID(Guid clientId);
        IQueryable<Invoice> GetInvoicesByDateCreated(DateOnly date);

        Task AddAsync(Invoice entity);
        Task DeleteAsync(Invoice entity);
        Task UpdateAsync(Invoice entity);


    }
}
