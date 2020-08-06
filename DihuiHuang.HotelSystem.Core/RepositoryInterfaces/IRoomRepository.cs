using DihuiHuang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.RepositoryInterfaces
{
    public interface IRoomRepository:IAsyncRepository<Room>
    {
        Task<IEnumerable<Room>> GetRoomsByType(int id);

    }
}
