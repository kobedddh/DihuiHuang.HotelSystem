using DihuiHuang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.RepositoryInterfaces
{
    public interface ICustomerRepository:IAsyncRepository<Customer>
    {
        Task<IEnumerable<Customer>> GetCustomersByRoom(int id);
        Task<Room> GetRoomByCustomerId(int id);
    }
}
