using AutoMapper;
using AWork.Contracts.Dto.Production;
using AWork.Domain.Base;
using AWork.Services.Abstraction.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Production
{
    internal class ProductSubCategoryService : IProductSubCategoryService
    {
        private IProductionRepositoryManager _productionRepositoryManager;
        private readonly IMapper _mapper;

        public ProductSubCategoryService(IProductionRepositoryManager productionRepositoryManager, IMapper mapper)
        {
            _productionRepositoryManager = productionRepositoryManager;
            _mapper = mapper;
        }

        public void Edit(ProductSubCategoryDto productSubCategoryDto)
        {
            //var prodcSubCategoryDto = _productionRepositoryManager.productSubCategory.GetProcdSubCateById(productSubCategoryDto,false);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductSubCategoryDto>> GetAllProdcSubCategory(bool trackChanges)
        {
            var procdSubCategory = await _productionRepositoryManager.productSubCategory.GetAllProdcSubCategory(trackChanges);
            var procdSubCategoryDto =_mapper.Map<IEnumerable<ProductSubCategoryDto>>(procdSubCategory);
            return procdSubCategoryDto;
        }

        public Task<ProductSubCategoryDto> GetProcdSubCateById(int prodcSubCategory, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductSubCategoryForCreateDto productSubCategoryForCreat)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductSubCategoryDto productSubCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
