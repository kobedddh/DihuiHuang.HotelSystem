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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost]
        //fix routing afterward
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] RoomRequestModel model)
        {
            var response = await _roomService.CreateRoom(model);
            return Ok(response);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody] RoomRequestModel model)
        {
            await _roomService.DeleteRoom(model);
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> RoomList()
        {
            var response = await _roomService.GetAllRooms();
            return Ok(response);
        }



        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] RoomRequestModel model)
        {
            var response = await _roomService.UpdateRoom(model);
            return Ok(response);
        }



    }
}
