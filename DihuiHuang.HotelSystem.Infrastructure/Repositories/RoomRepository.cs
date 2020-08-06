using DihuiHuang.HotelSystem.Core.Entities;
using DihuiHuang.HotelSystem.Core.RepositoryInterfaces;
using DihuiHuang.HotelSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Infrastructure.Repositories
{
    public class RoomRepository : EFRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelSystemDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<IEnumerable<Room>> GetRoomsByType(int id)
        {
            var rooms = await _dbContext.Rooms.Where(r => r.RTCode == id).ToListAsync();
            return rooms;
        }

    }
}
