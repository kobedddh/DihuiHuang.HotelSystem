using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DihuiHuang.HotelSystem.Core.Entities;
using DihuiHuang.HotelSystem.Core.Models.Requests;
using DihuiHuang.HotelSystem.Core.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DihuiHuang.HotelSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpPost]
        //fix routing afterward
        [Route("create")]
        public async Task<IActionResult> CreateService([FromBody] ServiceRequestModel model)
        {
            var service = await _serviceService.CreateService(model);
            return Ok(service);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> DeleteService([FromBody] ServiceRequestModel model)
        {
            await _serviceService.DeleteService(model);
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> ServiceList()
        {
            var services = await _serviceService.GetAllServices();
            return Ok(services);
        }

        [HttpGet]
        [Route("{roomNo:Int}")]
        public async Task<IActionResult> GetServicesByRoom(int roomNo)
        {
            var services = await _serviceService.GetServicesByRoomNumber(roomNo);
            return Ok(services);
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateService([FromBody] ServiceRequestModel model)
        {
            var service = await _serviceService.UpdateService(model);
            return Ok(service);
        }
    }
}
