using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Repository;
using System;
using System.Collections.Generic;

namespace Hotel.Business
{
    public class BookingBusiness : IBookingBusiness
    {
        private BookingRepository _booking;
        public BookingBusiness(BookingRepository bookingRepository)
        {
            _booking = bookingRepository;
        }
        public bool Add(Booking booking)
        {
            _booking.Insert(booking);
            return true;
        }

        public List<Booking> GetList()
        {
            return _booking.GetList();
        }

    }
}
