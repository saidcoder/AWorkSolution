using AWork.Contracts.Dto.HumanResources.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Employee
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployee(bool trackChanges);

        Task<EmployeeDto> GetCategoryById(int BusinessEntityId, bool trackChange);
        void Insert(EmployeeDto employee);
        void Edit(EmployeeDto employee);
        void Remove(EmployeeDto employee);
    }
}
