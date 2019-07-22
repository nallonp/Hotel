using System;
using System.Collections.Generic;
using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using Repository;
using Repository.Interface;

namespace Hotel.Business
{
    public class IRoomBusiness : Interfaces.IRoomBusiness
    {
        private RoomRepository _repository;
        public IRoomBusiness(RoomRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Set the number of available rooms.
        /// </summary>
        /// <returns>List<Room></returns>
        public void AddRooms(Room room, uint number)
        {
            for (uint i = 0; i < number; i++)
            {
                _repository.Insert(room);
            }
        }
        /// <summary>
        /// Gets a list of all rooms.
        /// </summary>
        /// <returns>List<Room></returns>
        public List<Room> GetRooms()
        {
            return _repository.GetList();
        }

        /// <summary>
        /// Gets the rooms that match the type criteria.
        /// </summary>
        /// <returns>List<Room></returns>
        public List<Room> GetRoomsByType(ERoomType type)
        {
            return _repository.SelectRoomsByType(type);
        }
        /// <summary>
        /// Lock a number of rooms of the type specified.
        /// </summary>
        /// <param name="type">ERoomType</param>
        /// <param name="number">uint</param>
        public void LockRoomsByType(ERoomType type, uint number)
        {
            var rooms = _repository.SelectEmptyUnlockedRoomsByType(type);
            if (rooms.Count >= number)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    rooms[i].Locked = true;
                }
            }
            else
                throw new ArgumentException("Número de quartos disponíveis para trancar menor do que o desejado.");
        }
        /// <summary>
        /// Unlock a number of rooms of the type specified.
        /// </summary>
        /// <param name="type">ERoomType</param>
        /// <param name="number">uint</param>

        public void UnlockRoomsByType(ERoomType type, uint number)
        {
            var rooms = _repository.SelectLockedRoomsByType(type);
            if (rooms.Count >= number)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    rooms[i].Locked = true;
                }
            }
            else
                throw new ArgumentException("Número de quartos disponíveis para destrancar menor do que o desejado.");
        }

    }
}