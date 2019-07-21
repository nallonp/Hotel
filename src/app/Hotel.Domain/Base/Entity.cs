using Hotel.Domain.Interfaces;
using System;

namespace Hotel.Domain.Base
{
    public abstract class Entity : IEntity, IComparable<IEntity>
    {
        public Guid Guid { get; set; }
        public ulong Id { get; set; }

        public int CompareTo(IEntity other)
        {
            if (this.Id > other.Id)
                return -1;
            else if (this.Id == other.Id)
                return 0;
            else
                return -1;
        }
    }
}
