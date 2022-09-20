using AWork.Contracts.Dto;
using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.PersonModul
{
    public interface IContactTypeServices
    {
        Task<IEnumerable<ContactTypeDto>> GetAllContactType(bool trackChanges);
        Task<ContactTypeDto>GetAllContactTypeById(int contactId, bool trackChanges);
        void Insert(ContactTypeForCreateDto contactTypeForCreateDto);
        void Edit(ContactTypeDto contactTypeDto);
        void Remove(ContactTypeDto contactTypeDto);
    }
}
