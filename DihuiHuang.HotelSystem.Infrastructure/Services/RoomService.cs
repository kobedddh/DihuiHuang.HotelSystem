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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private readonly IMapper _mapper;
        public RoomService(IRoomRepository roomRepository,IMapper mapper)
        {
            _roomRepository = roomRepository;
            _mapper = mapper;
        }
        public async Task<RoomResponseModel> CreateRoom(RoomRequestModel roomRequestModel)
        {
            var room = _mapper.Map<Room>(roomRequestModel);
            var createdRoom = await _roomRepository.AddAsync(room);
            return _mapper.Map<RoomResponseModel>(createdRoom);
        }

        public async Task DeleteRoom(RoomRequestModel roomRequestModel)
        {
            var room = _mapper.Map<Room>(roomRequestModel);
            await _roomRepository.DeleteAsync(room);
        }

        public async Task<RoomResponseModel> UpdateRoom(RoomRequestModel roomRequestModel)
        {
            var room = _mapper.Map<Room>(roomRequestModel);
            var updatedRoom = await _roomRepository.UpdateAsync(room);
            return _mapper.Map<RoomResponseModel>(updatedRoom);
        }

        public async Task<IEnumerable<RoomResponseModel>> GetAllRooms()
        {
            var rooms = await _roomRepository.ListAllAsync();
            var response = _mapper.Map<IEnumerable<RoomResponseModel>>(rooms);
            return response;
        }

        public async Task<IEnumerable<RoomResponseModel>> GetRoomsByType(int id)
        {
            var rooms = await _roomRepository.GetRoomsByType(id);
            var response = _mapper.Map<IEnumerable<RoomResponseModel>>(rooms);
            return response;
        }
    }
}
