using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.HumanResource
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetAllDepartment(bool trackChanges);
        Task<Department> GetDepartmentById(int id, bool trackChanges);

        void Insert(Department department);

        void Edit(Department department);

        void Remove(Department department);


    }
}
