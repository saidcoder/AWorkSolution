using AWork.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.PersonModul
{
    public interface IPersonServices
    {
        Task<IEnumerable<PersonDto>> GetAllPerson(bool trackChanges);
        Task<PersonDto> GetAllPersonById(int personId, bool trackChanges);
        void Insert(PersonForCreateDto personForCreateDto);
        void Edit(PersonDto personDto);
        void Delete(PersonDto personDto);
    }
}
