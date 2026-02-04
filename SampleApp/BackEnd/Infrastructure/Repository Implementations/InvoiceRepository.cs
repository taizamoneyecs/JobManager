using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Invoice;
using BackEnd.Infrastructure.Data;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class InvoiceRepository : IInvoiceRepository<Invoice>, IDisposable
    {
        readonly AppDbContext _context;
        public InvoiceRepository(AppDbContext context)
        {
            _context = context;
        }
        public IQueryable<Invoice> GetInvoicesByID(Guid id)
        {
            return _context.Invoices.Where(i => i.ID == id);
        }

        public IQueryable<Invoice> GetInvoicesByClientID(Guid clientId)
        {
            return _context.Invoices.Where(i => i.ClientID == clientId);
        }
        public IQueryable<Invoice> GetAllInvoices()
        {
                       return _context.Invoices;
        }

        public IQueryable<Invoice> GetInvoicesByDateCreated(DateTime date)
        {  
            return _context.Invoices.Where(i => i.DateCreated == date); 
        }
        public async Task AddAsync(Invoice entity)
        {
            await _context.Invoices.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Invoice entity)
        {
            _context.Invoices.Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Invoice entity)
        {
            _context.Invoices.Update(entity);
            await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            ((IDisposable)_context).Dispose();
        }
    }
}
