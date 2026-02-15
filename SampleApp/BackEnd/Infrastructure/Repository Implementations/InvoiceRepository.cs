using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Invoice;
using BackEnd.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace BackEnd.Infrastructure.Repository_Implementations
{
    public class InvoiceRepository : IInvoiceRepository
    {
        readonly AppDbContext _context;
        public InvoiceRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateAsync(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Invoice> GetAllAsync()
        {
            return await _context.Invoices.ToListAsync();
        }
        public async Task<Invoice?> GetInvoiceByIDAsync(Guid id)
        {
            return await _context.Invoices.FindAsync(id);
        }
        public async Task<List<Invoice>> GetInvoicesByClientIDAsync(Guid clientId)
        {
            var invoices = await _context.Invoices
                .Where(i => i.ClientId == clientId)
                .ToListAsync();
            return invoices;
        }
        public async Task<List<Invoice>> GetInvoicesByDateCreatedAsync(DateTime date)
        {
            var invoices = await _context.Invoices
                .Where (i => i.DateCreated == date)
                .ToListAsync();
            return invoices;
        }


    }
}
}
