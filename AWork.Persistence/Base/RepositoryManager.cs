using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.Sales;
using AWork.Persistence.Repositories.Sales;

namespace AWork.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private CreditCardRepository _creditcardRepository;
        private PersonCreditCardRepository _personcreditcardRepository;
        private SalesOrderHeaderRepository _salesorderheaderRepository;

        /*private ICategoryRepository _categoryRepository;*/

        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public ICreditCardRepository CreditCardRepository /*=> throw new NotImplementedException();*/
        {
            get
            {
                if (_creditcardRepository == null)
                {
                    _creditcardRepository = new CreditCardRepository(_dbContext);
                }
                return _creditcardRepository;
            }
        }

        public IPersonCreditCardRepository PersonCreditCard /*=> throw new NotImplementedException();*/
        {
            get
            {
                if (_personcreditcardRepository == null)
                {
                    _personcreditcardRepository = new PersonCreditCardRepository(_dbContext);
                }
                return _personcreditcardRepository;
            }
        }


        public ISalesOrderHeaderRepository SalesOrderHeader /*=> throw new NotImplementedException();*/
        {
            get
            {
                if (_salesorderheaderRepository == null)
                {
                    _salesorderheaderRepository = new SalesOrderHeaderRepository(_dbContext);
                }
                return _salesorderheaderRepository;
            }
        }
        

        /*public ICategoryRepository CategoryRepository
        {
            get {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_dbContext);
                }
                return _categoryRepository; 
            }
        }*/



        public void Save () => _dbContext.SaveChanges();
        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();

    }
}
