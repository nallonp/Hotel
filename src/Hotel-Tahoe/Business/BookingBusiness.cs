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
        public void AddBooking(Booking booking)
        {   
            _repository.Insert(booking);
        }
        public double CalcExpenses(Client client)
        {
            throw new NotImplementedException();
        }
        public void CancelBooking(uint id)
        {
            var booking = _repository.SelectById(id);
            booking.CheckOutDate = DateTime.Now;
            _repository.Update(booking);
        }
        public void EmptyRooms(IList<Booking> bookings)
        {
            foreach (var b in bookings)
            {
                b.Room.Empty = true;
            }
        }
        public IList<Booking> GetBookings()
        {
            return _repository.GetList();
        }
        public IList<Booking> GetBookingsByClient(string cpf)
        {
            return _repository.SelectBookingsByClient(cpf);
        }
    }
}
