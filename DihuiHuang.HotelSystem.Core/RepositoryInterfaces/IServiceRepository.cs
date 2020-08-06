using DihuiHuang.HotelSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DihuiHuang.HotelSystem.Core.RepositoryInterfaces
{
    public interface IServiceRepository:IAsyncRepository<Service>
    {
        Task<IEnumerable<Service>> GetServicesByRoom(int roomNO);
    }
}
