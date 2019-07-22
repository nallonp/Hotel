using Hotel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class BookingRepository : GenericRepository<Booking>
    {
        public IList<Booking> SelectOneMonthRevenue()
        {
            return GetList().Where(x => x.CheckOutDate >= DateTime.Today&&x.CheckOutDate<=DateTime.Today.AddDays(30)).ToList();
        }
        public IList<Booking> SelectBookingsByClient(string cpf) {
            return GetList().Where(x => x.Client.CPF == cpf).ToList();
        }
    }
}
