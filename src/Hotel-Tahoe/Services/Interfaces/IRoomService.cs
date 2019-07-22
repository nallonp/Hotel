using Hotel.Business;
using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services.Interfaces
{
    public interface IRoomService
    {
        void AddRoomsByType(Room room, uint number);
        List<Room> GetRoomsByType(ERoomType type);
        void UnlockRoomsByType(ERoomType type, uint number);
        void LockRoomsByType(ERoomType type, uint number);
        //StatisticsOfRooms GetStatisticsOfRooms(IList<Room> rooms);
    }
}
