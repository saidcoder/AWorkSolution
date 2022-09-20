using AWork.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.PersonModul
{
    public interface IBusinessEntityServices
    {
        Task<IEnumerable<BusinessEntityDto>> GetAllBusinessEntity(bool trackChanges);

        Task<BusinessEntityDto> GetBusinessEntityById(int businessEntityid, bool trackChanges);

        void insert(BusinessEntityForCreateDto businessEntityForCreateDto);
        void edit (BusinessEntityDto businessEntityDto);
        void delete (BusinessEntityDto businessEntityDto);
    }
}
