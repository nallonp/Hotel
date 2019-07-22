using Hotel.Domain.Entities;
using System;

namespace Hotel.Services.Interfaces
{
    public interface IBookingService
    {
        void AddBooking(Client client, Room room, DateTime chekin, DateTime checkout);
    }
}
