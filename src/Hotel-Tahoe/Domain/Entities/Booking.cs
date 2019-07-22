using Hotel_Tahoe.Domain.Interfaces;
using System;

namespace Hotel.Domain.Entities
{
    public class Booking : GenericEntity, IBooking
    {
        public DateTime CheckOutDate { get; set; }
        public Room Room { get; set; }
        public Client Client { get; set; }
        public DateTime CheckInDate { get; set; }
        public double value { get; set; }
    }
}
