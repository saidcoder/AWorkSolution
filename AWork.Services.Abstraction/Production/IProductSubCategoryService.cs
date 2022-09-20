using AWork.Contracts.Dto.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Abstraction.Production
{
    public interface IProductSubCategoryService
    {
        //trackChanges => feature untuk mendekteksi perubahan data diobject category
        Task<IEnumerable<ProductSubCategoryDto>> GetAllProdcSubCategory(bool trackChanges);

        //craete 1 record with this code
        Task<ProductSubCategoryDto> GetProcdSubCateById(int prodcSubCategory, bool trackChanges);
        void Insert(ProductSubCategoryForCreateDto productSubCategoryForCreat);
        void Edit(ProductSubCategoryDto productSubCategoryDto);
        void Remove(ProductSubCategoryDto productSubCategoryDto);
    }
}
