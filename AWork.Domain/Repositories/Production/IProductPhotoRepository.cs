﻿using AWork.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Domain.Repositories.Production
{
    public interface IProductPhotoRepository
    {
        Task<IEnumerable<ProductPhoto>> GetAllProductPhoto(bool trackChanges);
        Task<ProductPhoto> GetProductPhotoById(int ProductPhotoId, bool trackChanges);
        void Insert(ProductPhoto productPhoto);
        void Edit(ProductPhoto productPhoto);
        void Remove(ProductPhoto productPhoto);

    }
}
