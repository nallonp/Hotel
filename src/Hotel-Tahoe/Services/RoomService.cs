using System.Collections.Generic;
using Hotel.Business;
using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Hotel.Services.Interfaces;

namespace Hotel.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomBusiness _roomBusiness;
        public RoomService(IRoomBusiness roomBusiness)
        {
            _roomBusiness = roomBusiness;
        }

        public void AddRoomsByType(Room room, uint number)
        {
            _roomBusiness.AddRooms(room, number);
        }

        public List<Room> GetRoomsByType(ERoomType type)
        {
            return _roomBusiness.GetRoomsByType(type);
        }
        public void LockRoomsByType(ERoomType type, uint number)
        {
            _roomBusiness.LockRoomsByType(type, number);
        }

        public void UnlockRoomsByType(ERoomType type, uint number)
        {
            _roomBusiness.UnlockRoomsByType(type, number);
        }
    }
}