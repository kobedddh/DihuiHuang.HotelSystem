using System;
using System.Collections.Generic;
using System.Text;

namespace DihuiHuang.HotelSystem.Core.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RTCode { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

    }
}
