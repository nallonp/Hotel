using Hotel.Domain.Entities.ValueObj;
using Hotel_Tahoe.Domain.Interfaces;

namespace Hotel.Domain.Entities
{
    public class Room : GenericEntity, IRoom
    {
        public double Price { get; set; }
        public bool Empty { get; set; }
        public bool Locked { get; set; }
        public ERoomType Type { get; set; }
    }
}
