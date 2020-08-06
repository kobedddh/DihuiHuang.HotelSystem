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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        //fix routing afterward
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] CustomerRequestModel model)
        {
            var response = await _customerService.CreateCustomer(model);
            return Ok(response);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody] CustomerRequestModel model)
        {
            await _customerService.DeleteCustomer(model);
            return Ok();
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> CustomerList()
        {
            var response = await _customerService.GetAllCustomers();
            return Ok(response);
        }



        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] CustomerRequestModel model)
        {
            var response = await _customerService.UpdateCustomer(model);
            return Ok(response);
        }

        //[HttpGet]
        //[Route("{roomNo:Int}")]
        //public async Task<IActionResult> GetCustomersByRoom(int roomNo)
        //{
        //    var response = await _customerService.GetCustomerByRoom(roomNo);
        //    return Ok(response);
        //}

        [HttpGet]
        [Route("{id:Int}")]
        public async Task<IActionResult> GetRoomByCustomer(int id)
        {
            var response = await _customerService.GetRoomByCustomer(id);
            return Ok(response);
        }
    }
}
