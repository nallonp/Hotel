using System.Collections.Generic;
using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository;
using Repository.Interface;

namespace Hotel.Business
{
    public class RoomBusiness : IRoomBusiness
    {
        private RoomRepository _repository;

        public RoomBusiness(RoomRepository repository)
        {
            _repository = repository;
        }
        public void Add(Room room, uint number)
        {
            for (uint i = 0; i < number; i++)
            {
                _repository.Insert(room);
            }
        }
        public List<Room> GetRoomsByType(ERoomType type)
        {
            return _repository.SelectByType(type);
        }

        public List<Room> GetVacantRooms()
        {
            return _repository.SelectVacantRooms();
        }
    }
}