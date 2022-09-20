using AWork.Domain.Models;
using AWork.Domain.Repositories.Sales;
using AWork.Persistence.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Persistence.Repositories.Sales
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(AdventureWorks2019Context dbContext) : base(dbContext)
        {
        }

        public void Edit(Customer customer)
        {
            Update(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer(bool trackChanges)
        {
            return await FindAll(trackChanges).OrderBy(c => c.CustomerId).ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int customerId, bool trackChanges)
        {
            return await FindByCondition(c => c.CustomerId.Equals(customerId), trackChanges).SingleOrDefaultAsync();
        }

        public void Insert(Customer customer)
        {
            Create(customer);
        }

        public void Remove(Customer customer)
        {
            Delete(customer);
        }
    }
}
