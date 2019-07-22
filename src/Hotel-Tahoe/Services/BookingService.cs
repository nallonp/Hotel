using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Hotel.Services.Interfaces;
using System;

namespace Hotel.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingBusiness _bookingBusiness;
        public BookingService(IBookingBusiness bookingBusiness)
        {
            _bookingBusiness = bookingBusiness;
        }
        public void AddBooking(Client client, Room room, DateTime chekin, DateTime checkout)
        {
            _bookingBusiness.AddBooking(
                new Booking()
                {
                    Room = room,
                    Client = client,
                    CheckInDate = chekin,
                    CheckOutDate = checkout
                }
            );
        }

    }
}
