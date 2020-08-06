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
    public class ServiceRepository : EFRepository<Service>, IServiceRepository
    {
        public ServiceRepository(HotelSystemDbContext dbContext):base(dbContext)
        {
        }

        public async Task<IEnumerable<Service>> GetServicesByRoom(int roomNo)
        {
            var services = await _dbContext.Services.Where(s => s.RoomNo == roomNo).ToListAsync();
            return services;
        }
    }
}
