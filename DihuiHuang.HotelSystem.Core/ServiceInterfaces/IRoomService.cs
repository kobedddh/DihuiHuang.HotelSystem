using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.ServiceInterfaces
{
    public interface IRoomService
    {
        Task<RoomResponseModel> CreateRoom(RoomRequestModel roomRequestModel);
        Task<RoomResponseModel> UpdateRoom(RoomRequestModel roomRequestModel);
        Task DeleteRoom(RoomRequestModel roomRequestModel);
        Task<IEnumerable<RoomResponseModel>> GetAllRooms();
        Task<IEnumerable<RoomResponseModel>> GetRoomsByType(int id);
    }
}
