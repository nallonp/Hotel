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
        public List<Room> SelectByType(ERoomType type)
        {
            return GetList().Where(room => room.Type == type).ToList();
        }
        public List<Room> SelectAvailableRooms()
        {
            return GetList().Where(room => room.Empty == true && room.Active == true).ToList();
        }
        public Room SelectAvailableRoom()
        {
            return GetList().Where(room => room.Empty && room.Active).Min();
            
        }
        public List<Room> SelectRoomsByType(ERoomType type)
        {
            return GetList().Where(room => room.Type == type).ToList();
        }
    }
}
