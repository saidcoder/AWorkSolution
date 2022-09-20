using AWork.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.PersonModul
{
    public interface IStateProvinceServices
    {
        Task<IEnumerable<StateProvinceDto>> GetAllStateprovince(bool trackChanges);
        Task<StateProvinceDto>GetAllStateProvinceById(int stateId, bool trackChanges);
        void Insert(StateProvinceForCreateDto stateProvinceForCreateDto);
        void Edit(StateProvinceDto stateProvinceDto);
        void Remove(StateProvinceDto stateProvinceDto);
    }
}
