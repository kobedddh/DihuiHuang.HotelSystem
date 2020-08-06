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
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;
        private readonly IMapper _mapper;
        public RoomTypeService(IRoomTypeRepository roomTypeRepository,IMapper mapper)
        {
            _roomTypeRepository = roomTypeRepository;
            _mapper = mapper;
        }
        public async Task<RoomTypeResponseModel> CreateRoomType(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = _mapper.Map<RoomType>(roomTypeRequestModel);
            var createdRoomType = await _roomTypeRepository.AddAsync(roomType);
            return _mapper.Map<RoomTypeResponseModel>(createdRoomType);
        }

        public async Task DeleteRoomType(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = _mapper.Map<RoomType>(roomTypeRequestModel);
            await _roomTypeRepository.DeleteAsync(roomType);
        }

        public async Task<RoomTypeResponseModel> UpdateRoomType(RoomTypeRequestModel roomTypeRequestModel)
        {
            var roomType = _mapper.Map<RoomType>(roomTypeRequestModel);
            var updatedRoomType = await _roomTypeRepository.UpdateAsync(roomType);
            return _mapper.Map<RoomTypeResponseModel>(updatedRoomType);
        }

        public async Task<IEnumerable<RoomTypeResponseModel>> GetAllRoomTypes()
        {
            var roomTypes = await _roomTypeRepository.ListAllAsync();
            var response = _mapper.Map<IEnumerable<RoomTypeResponseModel>>(roomTypes);
            return response;
        }


    }
}
