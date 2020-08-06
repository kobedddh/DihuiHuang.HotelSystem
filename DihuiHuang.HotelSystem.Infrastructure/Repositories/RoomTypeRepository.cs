using DihuiHuang.HotelSystem.Core.Entities;
using DihuiHuang.HotelSystem.Core.RepositoryInterfaces;
using DihuiHuang.HotelSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DihuiHuang.HotelSystem.Infrastructure.Repositories
{
    public class RoomTypeRepository : EFRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(HotelSystemDbContext dbContext) : base(dbContext)
        {
        }
    }
}
