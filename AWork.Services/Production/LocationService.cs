using AutoMapper;
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
    public class LocationService : ILocationService
    {
        private IRepositoryManager _repositoryManager;

        private readonly IMapper _mapper;

        public LocationService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LocationDto>> GetAllLocation(bool trackChange)
        {
            //throw new NotImplementedException();
            var locationModel = await _repositoryManager.LocationRepository.GetAllLocation(trackChange);
            var locationDto = _mapper.Map<IEnumerable<LocationDto>>(locationModel);
            return locationDto;
        }

        public Task<LocationDto> GetLocationById(int locationId, bool trackChange)
        {
            throw new NotImplementedException();
        }

        public void Insert(LocationDto location)
        {
            throw new NotImplementedException();
        }

        public void Edit(LocationDto location)
        {
            throw new NotImplementedException();
        }

        public void Remove(LocationDto location)
        {
            throw new NotImplementedException();
        }
    }
}
