using Hotel.Domain.Interfaces;
using System;

namespace Hotel.Domain.Entities
{
    public abstract class GenericEntity : IGenericEntity, IComparable<IGenericEntity>
    {
        public ulong Id { get; set; }

        public int CompareTo(IGenericEntity other)
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
