using AWork.Persistence;
using AWork.Domain.Base;
using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AWork.Domain.Repositories.HumanResource;
using AWork.Persistence.Repositories.HumanResource;

namespace AWork.Persistence.Base
{
    public class RepositoryManager : IRepositoryManager
    {
        private AdventureWorks2019Context _dbContext;
        private IDepartmentRepository _departmentRepository;
        private IShiftRepository _shiftRepository;
        /*private IEmployeeDepartmentHistoryRepository employeeDepartmentHistoryRepository;*/

        public RepositoryManager(AdventureWorks2019Context dbContext)
        {
            _dbContext = dbContext;
        }

        public IDepartmentRepository DepartmentRepository
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new DepartmentRepository(_dbContext);
                }
                return _departmentRepository;
            }
        }

        public IShiftRepository ShiftRepository
        {
            get
            {
                if (_shiftRepository == null)
                {
                    _shiftRepository = new ShiftRepository(_dbContext);
                }
                return _shiftRepository;
            }
        }

/*        public IEmployeeDepartmentHistoryRepository EmployeeDepartmentHistoryRepository
        {
            get
            {
                if (_employeeDepartmentHistoryRepository == null)
                {
                    _employeeDepartmentHistoryRepository = new EmployeeDepartmentHistoryRepository(_dbContext);
                }
                return _employeeDepartmentHistoryRepository;
            }
        }*/


        public void Save()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
