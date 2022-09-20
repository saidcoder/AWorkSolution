using AWork.Domain.Repositories.HumanResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface IRepositoryManager
    {
        /*ICategoryRepository CategoryRepository { get; }*/

        IShiftRepository ShiftRepository { get; }

        IEmployeeRepository EmployeeRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
