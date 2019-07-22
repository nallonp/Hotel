using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel_Tahoe.Repository.Interfaces
{
    public interface IBookingRepository
    {
       // IList<Booking> SelectOneMonthBookings();
        IList<Booking> SelectBookingsByClient(string cpf);
    }
}
