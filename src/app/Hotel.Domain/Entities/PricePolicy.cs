using Hotel.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Entities
{
    public class PricePolicy : Entity
    {
        public enum RoomType
        {
            Single,
            Standart,
            Luxo
        }
        private double Price { get; set; }
        private RoomType Type { get; set; }
        public PricePolicy(double price, RoomType type)
        {
            Price = price;
            Type = type;
        }
    }
}
