using AutoMapper;
using AWork.Contracts.Dto.Purchasing;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Services.Abstraction.Purchasing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Purchasing
{
    public class PurchaseOrderDetailService : IPurchaseOrderDetailService
    {
        private IPurchasingRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public PurchaseOrderDetailService(IPurchasingRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public void Edit(PurchaseOrderDetailDto purchaseOrderDetailDto)
        {
            var purchaseModel = _mapper.Map<PurchaseOrderDetail>(purchaseOrderDetailDto);
            _repositoryManager.PurchaseOrderDetailRepository.Edit(purchaseModel);
            _repositoryManager.Save();
        }

        public async Task<IEnumerable<PurchaseOrderDetailDto>> GetAllPurchaseOD(bool trackChanges)
        {
            var purchaseOHModel = await _repositoryManager.PurchaseOrderDetailRepository.GetAllPurchaseOrderDetail(false);
            var purchaseOHDto = _mapper.Map<IEnumerable<PurchaseOrderDetailDto>>(purchaseOHModel);
            return purchaseOHDto;
        }

        public async Task<PurchaseOrderDetailDto> GetPurchaseODById(int purchaseODId, bool trackChanges)
        {
            var purchaseModel = await _repositoryManager.PurchaseOrderDetailRepository.GetPurchaseOrderDetailById(purchaseODId, trackChanges);
            var purchaseDto = _mapper.Map<PurchaseOrderDetailDto>(purchaseModel);
            return purchaseDto;
        }

        public void Insert(PurchaseOrderDetailForCreateDto purchaseOrderDetailForCreateDto)
        {
            var purchaseModel = _mapper.Map<PurchaseOrderDetail>(purchaseOrderDetailForCreateDto);
            _repositoryManager.PurchaseOrderDetailRepository.Edit(purchaseModel);
            _repositoryManager.Save();
        }

        public void Remove(PurchaseOrderDetailDto purchaseOrderDetailDto)
        {
            var purchaseModel = _mapper.Map<PurchaseOrderDetail>(purchaseOrderDetailDto);
            _repositoryManager.PurchaseOrderDetailRepository.Edit(purchaseModel);
            _repositoryManager.SaveAsync();
        }
    }
}
