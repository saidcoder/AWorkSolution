using AutoMapper;
using AWork.Contracts.Dto.HumanResources.Employee;
using AWork.Domain.Base;
using AWork.Services.Abstraction.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        // ======= depedency injectorr ========== ///

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public EmployeeService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        
        // ========================================= //

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployee(bool trackChanges)
        {
            var employeeModel = await _repositoryManager.EmployeeRepository.GetAllEmployee(trackChanges);
            // source = categoryModel, target categoryDto
            var employeeDto = _mapper.Map<IEnumerable<EmployeeDto>>(employeeModel);
            return employeeDto;
        }

        public Task<EmployeeDto> GetCategoryById(int BusinessEntityId, bool trackChange)
        {
            throw new NotImplementedException();
        }

        public void Insert(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        public void Remove(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        public void Edit(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
