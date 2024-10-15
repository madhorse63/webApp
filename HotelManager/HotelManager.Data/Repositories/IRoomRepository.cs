using HotelManager.Data.Entites.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Data.Repositories
{
    public interface IRoomRepository
    {
        Task<IEnumerable<Room>> GetAllAsync();

        Task<Room> GetAsync(int id);

        Task CreateAsync(Room room);

        Task UpdateAsync(int id, Room room);

        Task RemoveAsync(int id);
    }
}
