using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DihuiHuang.HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeController(IRoomService roomService, IRoomTypeService roomTypeService)
        {
            _roomService = roomService;
            _roomTypeService = roomTypeService;
        }

        [HttpPost]
        //fix routing afterward
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] RoomTypeRequestModel model)
        {
            var response = await _roomTypeService.CreateRoomType(model);
            return Ok(response);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody] RoomTypeRequestModel model)
        {
            await _roomTypeService.DeleteRoomType(model);
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> RoomTypeList()
        {
            var response = await _roomTypeService.GetAllRoomTypes();
            return Ok(response);
        }



        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] RoomTypeRequestModel model)
        {
            var response = await _roomTypeService.UpdateRoomType(model);
            return Ok(response);
        }




        [HttpGet]
        [Route("{id:Int}")]
        public async Task<IActionResult> GetRoomsByType(int id)
        {
            var response = await _roomService.GetRoomsByType(id);
            return Ok(response);
        }
    }
}
