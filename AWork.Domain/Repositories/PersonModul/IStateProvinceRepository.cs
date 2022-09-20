﻿using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.PersonModul
{
    public interface IStateProvinceRepository
    {
        Task<IEnumerable<StateProvince>> GetAllStateProvince(bool trackChanges);
        Task<StateProvince> GetAllStateProvinceById(int StateId,bool trackChanges);
        void Insert(StateProvince stateProvince);
        void Edit(StateProvince stateProvince);
        void Remove(StateProvince stateProvince);
    }
}
