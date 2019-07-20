using Hotel.Domain.Entities.ValueObj;
using System;

namespace Hotel.Domain.Entities
{
    public class Room
    {
        public ERoomType Type { get; set; }
        public Boolean Occupied { get; set; }
        public Boolean Active { get; set; }
    }
}
