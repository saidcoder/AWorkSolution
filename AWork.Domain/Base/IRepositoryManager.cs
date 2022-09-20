﻿using AWork.Domain.Repositories.Person;
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
        IContactTypeRepository ContactTypeRepository { get; }

        void Save();

        Task SaveAsync();
    }
}
