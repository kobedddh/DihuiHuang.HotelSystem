using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.Entities
{
    public class RoomType
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string RTDesc { get; set; }
        public decimal Rent { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
