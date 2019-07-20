using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IRoomBusiness
    {
        void Add(Room room, uint number);
        List<Room> GetVacantRooms();
        List<Room> GetRoomsByType(ERoomType type);
    }
}
