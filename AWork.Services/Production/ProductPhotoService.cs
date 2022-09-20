﻿using AutoMapper;
using AWork.Contracts.Dto.Production;
using AWork.Domain.Base;
using AWork.Domain.Models;
using AWork.Services.Abstraction.Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Services.Production
{
    public class ProductPhotoService : IProductPhotoService
    {
        private IProductionRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ProductPhotoService(IProductionRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public void Edit(ProductPhotoDto productPhotoDto)
        {
            var productPhotoModel = _mapper.Map<ProductPhoto>(productPhotoDto);
            _repositoryManager.ProductPhotoRepository.Edit(productPhotoModel);
            _repositoryManager.Save();
        }

        public async Task<IEnumerable<ProductPhotoDto>> GetAllProductPhoto(bool trackChanges)
        {
            var productPhotoModel = await _repositoryManager.ProductPhotoRepository.GetAllProductPhoto(trackChanges);

            var productPhotoDto = _mapper.Map<IEnumerable<ProductPhotoDto>>(productPhotoModel);
            return productPhotoDto;
        }

        public async Task<ProductPhotoDto> GetProductPhotoById(int ProductPhotoId, bool trackChanges)
        {
            var productPhotoModel = await _repositoryManager.ProductPhotoRepository.GetProductPhotoById(ProductPhotoId, trackChanges);
            var productPhotoDto = _mapper.Map<ProductPhotoDto>(productPhotoModel);
            return productPhotoDto;
        }

        public void Insert(ProductPhotoForCreateDto productPhotoForCreateDto)
        {
            var productPhotoModel = _mapper.Map<ProductPhoto>(productPhotoForCreateDto);
            _repositoryManager.ProductPhotoRepository.Insert(productPhotoModel);
            _repositoryManager.Save();
        }

        public void Remove(ProductPhotoDto productPhotoDto)
        {
            var productPhotoModel = _mapper.Map<ProductPhoto>(productPhotoDto);
            _repositoryManager.ProductPhotoRepository.Remove(productPhotoModel);
            _repositoryManager.Save();
        }
    }
}
