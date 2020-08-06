using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.ServiceInterfaces
{
    public interface IServiceService
    {
        Task<ServiceResponseModel> CreateService(ServiceRequestModel serviceRequestModel);
        Task<ServiceResponseModel> UpdateService(ServiceRequestModel serviceRequestModel);
        Task DeleteService(ServiceRequestModel serviceRequestModel);
        Task<IEnumerable<ServiceResponseModel>> GetAllServices();
        Task<IEnumerable<ServiceResponseModel>> GetServicesByRoomNumber(int roomNo);
    }
}
