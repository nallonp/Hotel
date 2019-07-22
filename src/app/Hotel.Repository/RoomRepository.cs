using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class RoomRepository : GenericRepository<Room>
    {
        public List<Room> SelectAvailableRooms()
        {
            return GetList().Where(room => room.Empty == true && room.Locked == true).ToList();
        }
        public Room SelectAvailableRoom()
        {
            return GetList().Where(room => room.Empty && room.Locked).FirstOrDefault();
        }
        public List<Room> SelectRoomsByType(ERoomType type)
        {
            return GetList().Where(room => room.Type == type).ToList();
        }
        public List<Room> SelectEmptyUnlockedRoomsByType(ERoomType type)
        {
            return GetList().Where(room => room.Empty == true && room.Locked == false && room.Type == type).ToList();
        }
        public List<Room> SelectLockedRoomsByType(ERoomType type)
        {
            return GetList().Where(room => room.Locked == true && room.Type == type).ToList();
        }
    }
}
