﻿using CRMManager.Domain.Aggregates.CustomerAggregate;
using CRMManager.Domain.Aggregates.CustomerAggregate.Repository;
using CRMManager.Domain.Aggregates.CustomerAggregate.ValueObjects;
using CRMManager.Domain.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMManager.Infrastructure.Persistence.Respositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CRMManagerContext _context;

        public CustomerRepository(CRMManagerContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Customer entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        

        public async Task DeleteAsync(CustomerId id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if(customer != null)
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.AsNoTracking().ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(CustomerId id)
        {
            return await _context.Customers.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Customer entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
