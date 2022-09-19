using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.HumanResource
{
    public interface IShiftRepository
    {
        Task<IEnumerable<Shift>> GetAllDepartment(bool trackChanges);
        Task<Shift> GetDepartmentById(int id, bool trackChanges);

        void Insert(Shift shift);

        void Edit(Shift shift);

        void Remove(Shift shift);
    }
}
