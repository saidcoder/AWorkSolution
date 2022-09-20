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
    internal class ProductionCategoryService : IProductCategoryService
    {
        private IProductionRepositoryManager _productionRepositoryManager;
        private readonly IMapper _mapper;

        public ProductionCategoryService(IProductionRepositoryManager productionRepositoryManager, IMapper mapper)
        {
            _productionRepositoryManager = productionRepositoryManager;
            _mapper = mapper;
        }

        public void Edit(ProductCategoryDto productCategoryDto)
        {
            //Edit(productCategoryDto);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductCategoryDto>> GetAllProdcCategory(bool trackChanges)
        {
            var procdCategory = await _productionRepositoryManager.productCategory.GetAllProdcCategory(trackChanges);
            var prodcCategoryDto = _mapper.Map<IEnumerable<ProductCategoryDto>>(procdCategory);
            return prodcCategoryDto;
        }
        
        public Task<ProductCategoryDto> GetProcdCateById(int prodcCategory, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void Insert(ProductCategoryForCreatDto productCategoryForCreat)
        {
            throw new NotImplementedException();
        }

        public void Remove(ProductCategoryDto productCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
