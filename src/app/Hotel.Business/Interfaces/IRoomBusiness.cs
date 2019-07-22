using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IRoomBusiness
    {
        void AddRooms(Room room, uint number);
        List<Room> GetRoomsByType(ERoomType type);
        void LockRoomsByType(ERoomType type, uint number);
        void UnlockRoomsByType(ERoomType type, uint number);
        List<Room> GetRooms();
    }
}
