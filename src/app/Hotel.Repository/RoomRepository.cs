using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class RoomRepository : Repository<Room>
    {
        public List<Room> SelectByType(ERoomType type)
        {
            return GetList().Where(room => room.Type == type).ToList();
        }
        public List<Room> SelectVacantRooms()
        {
            return GetList().Where(room => room.Occupied == false).ToList();
        }
        public List<Room> SelectRoomsByType(ERoomType type)
        {
            return GetList().Where(room => room.Type == type).ToList();
        }
    }
}
