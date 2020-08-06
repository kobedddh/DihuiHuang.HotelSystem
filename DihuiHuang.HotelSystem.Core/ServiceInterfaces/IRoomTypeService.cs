using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.ServiceInterfaces
{
    public interface IRoomTypeService
    {
        Task<RoomTypeResponseModel> CreateRoomType(RoomTypeRequestModel roomTypeRequestModel);
        Task<RoomTypeResponseModel> UpdateRoomType(RoomTypeRequestModel roomTypeRequestModel);
        Task DeleteRoomType(RoomTypeRequestModel roomTypeRequestModel);
        Task<IEnumerable<RoomTypeResponseModel>> GetAllRoomTypes();
    }
}
