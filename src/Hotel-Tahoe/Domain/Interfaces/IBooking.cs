using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Tahoe.Domain.Interfaces
{
    public interface IBooking
    {
        DateTime CheckOutDate { get; set; }
        Room Room { get; set; }
        Client Client { get; set; }
        DateTime CheckInDate { get; set; }
    }
}
