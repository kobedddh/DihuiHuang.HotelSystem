using AutoMapper;
using DihuiHuang.HotelSystem.Core.Entities;
using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.Models.Responses;
using DihuiHuang.HotelSystem.Core.RepositoryInterfaces;
using DihuiHuang.HotelSystem.Core.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Infrastructure.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;
        public ServiceService(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }
        public async Task<ServiceResponseModel> CreateService(ServiceRequestModel serviceRequestModel)
        {
            var service = _mapper.Map<Service>(serviceRequestModel);
            var createdService= await _serviceRepository.AddAsync(service);
            return _mapper.Map<ServiceResponseModel>(createdService);
        }

        public async Task DeleteService(ServiceRequestModel serviceRequestModel)
        {
            var service = _mapper.Map<Service>(serviceRequestModel);
            await _serviceRepository.DeleteAsync(service);
        }

        public async Task<ServiceResponseModel> UpdateService(ServiceRequestModel serviceRequestModel)
        {
            var service = _mapper.Map<Service>(serviceRequestModel);
            var updatedService = await _serviceRepository.UpdateAsync(service);
            return _mapper.Map<ServiceResponseModel>(updatedService);
        }

        public async Task<IEnumerable<ServiceResponseModel>> GetAllServices()
        {
            var services = await _serviceRepository.ListAllAsync();
            var response = _mapper.Map<IEnumerable<ServiceResponseModel>>(services);
            return response;
        }

        public async Task<IEnumerable<ServiceResponseModel>> GetServicesByRoomNumber(int roomNo)
        {
            var services = await _serviceRepository.GetServicesByRoom(roomNo);
            var response = _mapper.Map<IEnumerable<ServiceResponseModel>>(services);
            return response;
        }
    }
}
