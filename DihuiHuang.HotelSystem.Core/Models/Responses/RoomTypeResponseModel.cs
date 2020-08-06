using DihuiHuang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.Models.Responses
{
    public class RoomTypeResponseModel
    {
        public int Id { get; set; }
        public string RTDesc { get; set; }
        public decimal Rent { get; set; }
        //public ICollection<RoomResponseModel> Rooms { get; set; }
    }
}
