using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.Models.Requests
{
    public class RoomTypeRequestModel
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string RTDesc { get; set; }
        public decimal Rent { get; set; }
    }
}
