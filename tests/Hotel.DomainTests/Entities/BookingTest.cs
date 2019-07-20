using Hotel.Domain.Entities;
using Hotel.Domain.Entities.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Hotel.DomainTests.Entities
{
    public class BookingTest
    {
        [Fact]
        public void BookingSucess()
        {
            DateTime date = DateTime.Today ;

            var booking = new Booking
            {
                CheckInDate = date,
                CheckOutDate = date,
                Client = new Client
                {
                    CPF = "000",
                    Email = "bla@uol",
                    Nome = "Zé",
                    Telefone = "000"
                },
                Room = new Room
                {
                    Active = true,
                    Occupied = true,
                    Type = ERoomType.Luxo
                }
            };
            Assert.True(
                booking.CheckInDate == date &&
                booking.CheckOutDate == date &&
                booking.Client.CPF == "000" &&
                booking.Client.Email == "bla@uol" &&
                booking.Client.Telefone == "000" &&
                booking.Room.Active == true &&
                booking.Room.Occupied == true &&
                booking.Room.Type == ERoomType.Luxo);
        }
    }
}
