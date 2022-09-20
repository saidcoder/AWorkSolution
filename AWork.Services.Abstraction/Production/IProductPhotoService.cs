using AWork.Contracts.Dto.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Production
{
    public interface IProductPhotoService
    {
        Task<IEnumerable<ProductPhotoDto>> GetAllProductPhoto(bool trackChanges);
        Task<ProductPhotoDto> GetProductPhotoById(int ProductPhotoId, bool trackChanges);
        void Insert(ProductPhotoForCreateDto productPhotoForCreateDto);
        void Edit(ProductPhotoDto productPhotoDto);
        void Remove(ProductPhotoDto productPhotoDto);
    }
}
