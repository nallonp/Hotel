using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Business
{
    public class StatusOfOperation
    {
        public int NumberOfRooms { get; private set; }
        public int EmptyRooms { get; private set; }
        public int OccupiedRooms { get; private set; }
        public int LockedRooms { get; private set; }

        public StatusOfOperation(IList<Room> list)
        {
            NumberOfRooms = list.Count;
            EmptyRooms = list.Where(x => x.Empty == true).ToList().Count;
            OccupiedRooms = list.Where(x => x.Empty == false).ToList().Count;
            LockedRooms = list.Where(x => x.Locked == true).ToList().Count;
        }
    }
}
