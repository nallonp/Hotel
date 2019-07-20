using Hotel.Domain.Interfaces;
using System;

namespace Hotel.Domain.Base
{
    public abstract class Entity : IEntity
    { 
        public Guid Guid { get; set; }
        public long Id { get; set; }
    }
}
