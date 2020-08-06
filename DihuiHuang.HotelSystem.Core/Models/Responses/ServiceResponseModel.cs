using DihuiHuang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.Models.Responses
{
    public class ServiceResponseModel
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string SDesc { get; set; }
        public decimal? Amount { get; set; }
        public DateTime ServiceDate { get; set; }
        public virtual Room Room { get; set; }
    }
}
