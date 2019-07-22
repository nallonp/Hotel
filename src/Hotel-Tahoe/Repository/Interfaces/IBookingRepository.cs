using Hotel.Domain.Entities;
using System.Collections.Generic;

namespace Hotel_Tahoe.Repository.Interfaces
{
    public interface IBookingRepository
    {
        IList<Booking> SelectOneMonthRevenue();
        IList<Booking> SelectBookingsByClient(string cpf);
    }
}
