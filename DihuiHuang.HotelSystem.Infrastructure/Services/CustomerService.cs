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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository,IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<CustomerResponseModel> CreateCustomer(CustomerRequestModel customerRequestModel)
        {
            var customer = _mapper.Map<Customer>(customerRequestModel);
            var createdCustomer = await _customerRepository.AddAsync(customer);
            return _mapper.Map<CustomerResponseModel>(createdCustomer);
        }

        public async Task DeleteCustomer(CustomerRequestModel customerRequestModel)
        {
            var customer = _mapper.Map<Customer>(customerRequestModel);
            await _customerRepository.DeleteAsync(customer);
        }
        public async Task<CustomerResponseModel> UpdateCustomer(CustomerRequestModel customerRequestModel)
        {
            var customer = _mapper.Map<Customer>(customerRequestModel);
            var updatedCustomer = await _customerRepository.UpdateAsync(customer);
            return _mapper.Map<CustomerResponseModel>(updatedCustomer);
        }


        public async Task<IEnumerable<CustomerResponseModel>> GetAllCustomers()
        {
            var customers = await _customerRepository.ListAllAsync();
            var response = _mapper.Map<IEnumerable<CustomerResponseModel>>(customers);
            return response;
        }

        public async Task<IEnumerable<CustomerResponseModel>> GetCustomerByRoom(int id)
        {
            var customers = await _customerRepository.GetCustomersByRoom(id);
            var response = _mapper.Map<IEnumerable<CustomerResponseModel>>(customers);
            return response;
        }

        public async Task<RoomResponseModel> GetRoomByCustomer(int id)
        {
            var room = await _customerRepository.GetRoomByCustomerId(id);
            var response = _mapper.Map<RoomResponseModel>(room);
            return response;
        }
    }
}
