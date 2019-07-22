using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel.Business.Interfaces
{
    public interface IBookingBusiness
    {
        void AddBooking(Booking booking);
        IList<Booking> GetBookings();
        void CancelBooking(uint id);
        void EmptyRooms(IList<Booking> bookings);
        IList<Booking> GetBookingsByClient(string cpf);
        double CalcExpenses(IList<Booking> bookings);
        IList<Booking> GetOneMonthRevenue();
    }
}
