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
    public class CustomerRepository : EFRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(HotelSystemDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Customer>> GetCustomersByRoom(int id)
        {
            var customers = await _dbContext.Customers.Where(c => c.RoomNo == id).ToListAsync();
            return customers;
        }

        public async Task<Room> GetRoomByCustomerId(int id)
        {
            var room = await _dbContext.Customers.Where(c => c.RoomNo == id).Select(c => c.Room).FirstOrDefaultAsync();
            return room;
        }
    }
}
