using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.ServiceInterfaces
{
    public interface ICustomerService
    {
        Task<CustomerResponseModel> CreateCustomer(CustomerRequestModel customerRequestModel);
        Task<CustomerResponseModel> UpdateCustomer(CustomerRequestModel customerRequestModel);
        Task DeleteCustomer(CustomerRequestModel customerRequestModel);
        Task<IEnumerable<CustomerResponseModel>> GetAllCustomers();
        Task<IEnumerable<CustomerResponseModel>> GetCustomerByRoom(int id);
        Task<RoomResponseModel> GetRoomByCustomer(int id);

    }
}
