using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Interfaces
{
    public interface IBookingBusiness
    {
        bool Add(Booking booking);
        List<Booking> GetList();
    }
}
