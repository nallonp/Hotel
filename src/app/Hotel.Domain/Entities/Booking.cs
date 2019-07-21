using Hotel.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Entities
{
    public class Booking : Entity
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public Room Room { get; set; }
        public Client Client { get; set; }

        public Booking(DateTime checkin, DateTime checkout, Room room, Client client)
        {
            CheckInDate = checkin;
            CheckOutDate = checkout;
            Room = room;
            Client = client;
        }

    }
}
