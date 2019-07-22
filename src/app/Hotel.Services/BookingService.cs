using Hotel.Business;
using Hotel.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Services
{
    public class BookingService
    {
        private readonly IBookingBusiness _bookingBusiness;
        public BookingService(IBookingBusiness bookingBusiness)
        {
            _bookingBusiness = bookingBusiness;
        }
    }
}
