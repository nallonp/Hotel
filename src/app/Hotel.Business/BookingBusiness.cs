using Hotel.Business.Interfaces;
using Hotel.Domain.Entities;
using Repository;
using System;
using System.Collections.Generic;

namespace Hotel.Business
{
    public class BookingBusiness : IBookingBusiness
    {
        private BookingRepository _repository;
        public BookingBusiness(BookingRepository bookingRepository)
        {
            _repository = bookingRepository;
        }
        public bool AddBooking(Booking booking)
        {
            _repository.Insert(booking);
            return true;
        }
        public List<Booking> GetList()
        {
            return _repository.GetList();
        }

    }
}
