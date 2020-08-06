using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        [MaxLength(50)]
        public string SDesc { get; set; }
        public decimal Amount { get; set; }
        public DateTime ServiceDate { get; set; }
        public virtual Room Room { get; set; }
    }
}
