using Hotel.Domain.Base;
using Hotel.Domain.Entities.ValueObj;
using System;

namespace Hotel.Domain.Entities
{
    public class Room : Entity
    {
        public double Price { get; set; }
        public bool Empty { get; set; }
        public bool Active { get; set; }
        public ERoomType Type { get; set; }

        public Room(Double price, bool empty, bool active, ERoomType type)
        {
            Price = price;
            Empty = empty;
            Active = active;
            Type = type;
        }
    }
}
