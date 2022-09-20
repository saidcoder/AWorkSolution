using AWork.Domain.Repositories.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Base
{
    public interface IProductionRepositoryManager
    {
        /*ICategoryRepository CategoryRepository { get; }*/

        IUnitMeasureRepository UnitMeasureRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
